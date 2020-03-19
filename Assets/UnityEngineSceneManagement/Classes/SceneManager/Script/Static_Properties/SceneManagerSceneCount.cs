using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSceneCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("SceneManager.sceneCount");
        Debug.LogError($"当前加载的场景数是{SceneManager.sceneCount}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
