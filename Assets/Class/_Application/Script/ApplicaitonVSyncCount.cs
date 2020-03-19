using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicaitonVSyncCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //手动设置游戏的帧数
        Debug.LogError("手动设置帧数前，需要关闭Quality里面的垂直同步设定，否则会被忽略");
        Application.targetFrameRate = 60;
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
}
