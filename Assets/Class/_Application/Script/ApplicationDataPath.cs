using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationDataPath : MonoBehaviour
{
    string m_Path;

    void Start()
    {
        //Get the path of the Game data folder
        m_Path = Application.dataPath;

        //Output the Game data path to the console
        Debug.Log("游戏资源数据文件夹 : " + m_Path);
    }
}
