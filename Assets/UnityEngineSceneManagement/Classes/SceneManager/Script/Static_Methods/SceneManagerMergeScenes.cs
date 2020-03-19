using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMergeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      var a=  SceneManager.CreateScene("test1");
      var  b=SceneManager.CreateScene("test2");
        
        SceneManager.MergeScenes(SceneManager.GetActiveScene(),b);

Debug.LogError(SceneUtility.GetScenePathByBuildIndex(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
