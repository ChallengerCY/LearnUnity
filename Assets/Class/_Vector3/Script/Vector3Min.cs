using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Min : MonoBehaviour
{
    public Vector3 a = new Vector3(1, 2, 3);
    public Vector3 b = new Vector3(4, 3, 2);


    private void Start()
    {
        Debug.LogError("返回两个向量属性最小值");
        Example();
    }

    void Example()
    {
        print(Vector3.Min(a, b));     // prints (1.0f, 2.0f, 2.0f)
    }
}
