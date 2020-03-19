using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationConsoleLogPath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError($"log打印的日志地址是{Application.consoleLogPath}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
