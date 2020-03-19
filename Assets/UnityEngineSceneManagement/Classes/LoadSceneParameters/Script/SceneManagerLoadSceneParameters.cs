using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerLoadSceneParameters : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("LoadSceneParameters是一个结构体,创建一个LoadScene参数");
        
        LoadSceneParameters loadSceneParameters=new LoadSceneParameters(LoadSceneMode.Single);
        
        LoadSceneParameters loadSceneParameters2=new LoadSceneParameters(LoadSceneMode.Additive, LocalPhysicsMode.None);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
