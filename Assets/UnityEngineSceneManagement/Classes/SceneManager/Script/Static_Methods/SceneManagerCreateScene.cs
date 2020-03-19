using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerCreateScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //  Scene newScene = SceneManager.CreateScene("My New Scene");
      Debug.LogError("开始创建一个新的场景");
      Scene newScene = SceneManager.CreateScene("My New Scene", new CreateSceneParameters(LocalPhysicsMode.Physics2D));
      
      Debug.LogError($"当前的场景数是 {SceneManager.sceneCount}");
      
      
      Debug.LogError($"SceneManager.GetActiveScene() 用于打出当前脚本所在的场景名字");
      Debug.Log("Active Scene is '" + SceneManager.GetActiveScene().name + "'.");
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
}
