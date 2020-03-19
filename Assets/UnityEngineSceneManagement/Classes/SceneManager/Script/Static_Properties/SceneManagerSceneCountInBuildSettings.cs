using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSceneCountInBuildSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("SceneManager.sceneCountInBuildSettings");
        Debug.LogError($"Build setting中的场景数.编辑器模式将包含在进入播放模式之前打开的场景数是{SceneManager.sceneCountInBuildSettings}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
