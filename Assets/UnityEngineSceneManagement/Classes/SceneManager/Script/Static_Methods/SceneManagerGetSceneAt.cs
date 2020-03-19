using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGetSceneAt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string output = "";
        Debug.LogError(SceneManager.sceneCount);
        if (SceneManager.sceneCount > 0)
        {
            for (int n = 0; n < SceneManager.sceneCount; ++n)
            {
                Scene scene = SceneManager.GetSceneAt(n);
                output += scene.name;
                output += scene.isLoaded ? " (Loaded, " : " (Not Loaded, ";
                output += scene.isDirty ? "Dirty, " : "Clean, ";
                output += scene.buildIndex >= 0 ? " in build)\n" : " NOT in build)\n";
            }
        }
        else
        {
            output = "No open Scenes.";
        }
        //EditorUtility.DisplayDialog("Scene Summary", output, "Ok");
        
        Debug.LogError(output);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
