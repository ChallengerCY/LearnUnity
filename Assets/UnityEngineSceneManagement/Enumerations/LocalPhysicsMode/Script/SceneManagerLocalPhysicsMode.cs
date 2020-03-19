using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerLocalPhysicsMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError($"LocalPhysicsMode.None 没有本地2D或3D物理场景将被创建。 ");
        
        Debug.LogError("LocalPhysicsMode.Physics2D 一个本地的2D物理场景将被创建并归scene拥有。 ");
        
        Debug.LogError("LocalPhysicsMode.Physics3D 一个本地的2D物理场景将被创建并归scene拥有。 ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
