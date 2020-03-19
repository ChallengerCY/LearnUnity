using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGetSceneByBuildIndex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(SceneManager.sceneCountInBuildSettings);
        SceneManager.GetSceneByBuildIndex(1 );

        //根据场景名称获取场景 可以是build setting里面的最后名字或者是全名 不带.unity后缀。
        SceneManager.GetSceneByName("SceneManagerGetSceneByBuildIndex");

        //根据路径加载场景
        SceneManager.GetSceneByPath("Assets/UnityEngineSceneManagement/Classes/SceneManager/Scene/SceneManagerGetSceneByBuildIndex.unity");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
