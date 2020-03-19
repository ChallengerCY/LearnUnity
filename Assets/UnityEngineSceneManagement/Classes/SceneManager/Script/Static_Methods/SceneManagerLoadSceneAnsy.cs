using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * 场景加载原则
 * 要加载的场景必须添加到场景的build setting中
 * 给定的场景名可以是完整的场景路径，也可以是Build Settings窗口中显示的路径，也可以是场景名。
 * 如果只给出场景名，它将加载列表中匹配的第一个场景。如果您有多个同名但路径不同的场景，应该在构建设置中使用完整的场景路径。
 * 要加载的场景的名称可以不区分大小写。
 */


public class SceneManagerLoadSceneAnsy : MonoBehaviour
{
    void Update()
    {
        // Press the space key to start coroutine
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Use a coroutine to load the Scene in the background
            StartCoroutine(LoadYourAsyncScene());
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SceneManagerSceneCount");
        asyncLoad.completed += TestCallBack;
        asyncLoad.allowSceneActivation = false;
        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            Debug.LogError($"当前的加载进度是{asyncLoad.progress}");

            if (asyncLoad.progress >= 0.9f)
            {
                Debug.LogError("是否需要显示场景");
                if (Input.GetKeyDown(KeyCode.C))
                {
                    asyncLoad.allowSceneActivation = true;
                }
            }

            yield return null;
        }
        
       
    }

    /// <summary>
    /// 可以用来获取加载完的场景实例
    /// </summary>
    /// <param name="a"></param>
    private void TestCallBack(AsyncOperation a)
    {
        Debug.LogError(SceneManager.GetActiveScene().name);
        Debug.LogError($"回调的事件是{a.progress}");
    }
}
