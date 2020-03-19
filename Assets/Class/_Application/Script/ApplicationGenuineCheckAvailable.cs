using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationGenuineCheckAvailable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(Application.genuineCheckAvailable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
