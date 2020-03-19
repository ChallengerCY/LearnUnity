using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerCreateSceneParameters : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("CreateSceneParameters是一个结构体,创建一个场景构造参数");
        CreateSceneParameters a=new CreateSceneParameters(LocalPhysicsMode.None);
      
        // a.localPhysicsMode
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
