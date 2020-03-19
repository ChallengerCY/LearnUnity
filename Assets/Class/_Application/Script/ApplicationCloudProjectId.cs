using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationCloudProjectId : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(Application.cloudProjectId);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
