using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationIdentifier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(Application.identifier);
        
        // Debug.LogError(Application.installerName); 
        
        Debug.LogError($"Application.installMode: {Application.installMode}");
        
        Debug.LogError($"Application.internetReachability: {Application.internetReachability}");
        
      
            if (Application.isBatchMode)
            {
                Debug.Log("In BatchMode");
            }
        
            Debug.LogError(Application.isConsolePlatform);
            
        Debug.LogError($"Application.isConsolePlatform: {Application.isConsolePlatform}");
        
        Debug.LogError($"Application.isEditor: {Application.isEditor}");

      Debug.LogError($"Application.isMobilePlatform: {Application.isMobilePlatform}");

      if (Application.isPlaying)
      {
          print("In player or playmode");
      }
      
      Debug.LogError($"Application.persistentDataPath: {Application.persistentDataPath}");
      
      Debug.LogError($"Application.platform: {Application.platform}");
      
      Debug.LogError($"Application.productName: {Application.productName}");
      
    
      

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"Application.isFocused:{Application.isFocused}");
        
        //Debug.LogError($"Application.runInBackground: {Application.runInBackground}");
    }
}
