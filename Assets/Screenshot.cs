using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Screenshot : MonoBehaviour
{
    //保存图像信息，时间戳+像素RGB
    private  struct ImageData
    {
        public long timestamp;
        public byte[] data;
    }
    //tooltip在面板中变量注释提示
    [Tooltip("截图宽度px")]
    public int width;
    [Tooltip("截图高度py")]
    public int height;
    [Tooltip("截图存储路径")]
    public string path;
    public Camera cam;
    public bool capture;
    Texture2D mtexture;
    RenderTexture rt;
    Rect ret;
    void Start()
    {
        //如果没有找到camera，那么获得camera组件，该脚本要挂载到你的camera上
        if (cam == null)
        {
            cam = GetComponent<Camera>();
        }
    }
    //捕获屏幕与保存不要放在主线程中，放在协程或者单独开一个线程
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            capture = true;
            StartCoroutine(CaptureAndSave03());
            Debug.Log("REC!");
            
            /*if (!capture)
            {
               // cam.enabled = true;
                capture = true;
                StartCoroutine(CaptureAndSave03());
                Debug.Log("REC!");
            }
            else
            {
                //cam.enabled = false;
                capture = false;
                StopCoroutine(CaptureAndSave03());
                Debug.Log("REC STOP!");
            }*/
        }
    }
    //第一种截图方式，直接用unity自带截图函数，全屏截图，不能改变图像尺寸
    public IEnumerator CaptureAndSave01()
    {
        while(capture)
        {
        ImageData pack;
        pack.timestamp = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        ScreenCapture.CaptureScreenshot(pack.timestamp + ".png");
        yield return new WaitForSeconds(1);
        }
    }
    //第二种截图方式,将屏幕 图像存储到一个texture2D中去，可以设定图片尺寸
    public IEnumerator CaptureAndSave02()
    {
        while(capture)
        {
            //等待屏幕渲染结束后获取屏幕像素信息
            yield return new WaitForEndOfFrame();
            //创建一个texture2D对象
            mtexture = new Texture2D(width, height, TextureFormat.RGB24, false);
            ret.width = width;
            ret.height = height;
            //读取屏幕像素信息存储为纹理数据
            mtexture.ReadPixels(ret, 0, 0);
            mtexture.Apply();
            //将图片信息编码为字节信息 
            ImageData pack;
            pack.data = mtexture.EncodeToPNG();
            //保存图片到 你的路径
            pack.timestamp = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            FileStream file = File.Create(pack.timestamp + ".png");
            file.Write(pack.data, 0, pack.data.Length);
            file.Close();
        }
    }
    //通过camera截取
    public IEnumerator CaptureAndSave03()
    {
        while(capture)
        {
        yield return new WaitForEndOfFrame();
        //创建一个rendertexture
        rt = new RenderTexture(width, height, 0);
        //将rt设置为相机的渲染目标
        cam.targetTexture = rt;
        //开始渲染
        cam.Render();
        //激活渲染贴纸读取信息
        RenderTexture.active = rt;
        mtexture = new Texture2D(width, height, TextureFormat.RGBA32, false);
        ret.width = width;
        ret.height = height;
        //读取屏幕像素信息存储为纹理数据
        mtexture.ReadPixels(ret, 0, 0);
        mtexture.Apply();
        //释放相机，销毁渲染贴纸
        cam.targetTexture = null;
        RenderTexture.active = null;
        GameObject.Destroy(mtexture);
        //将图片信息编码为字节信息 
        ImageData pack;
        pack.data = mtexture.EncodeToPNG();
        //保存图片到 你的路径
        pack.timestamp = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        Debug.LogError(Application.persistentDataPath);
        path = Application.persistentDataPath;
        if (String.IsNullOrEmpty(path))
        {
            Debug.LogError("没有指定路径，图片生成到Asset目录下面");
            FileStream file = File.Create(pack.timestamp + ".png");
            file.Write(pack.data, 0, pack.data.Length);
            file.Close();
        }
        else
        {
            Debug.LogError($"图片生成到目录{path+"/"}下面");
            FileStream file = File.Create(path+"/"+pack.timestamp + ".png");
            file.Write(pack.data, 0, pack.data.Length);
            file.Close();
        }
        capture = false;
        Debug.Log("REC STOP!");
        }
    }
}
