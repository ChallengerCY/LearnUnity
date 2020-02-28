using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3Scale : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.LogError("返回两个向量的相乘");
            Example();
        }

        void Example()
        {
            print(Vector3.Scale(new Vector3(1, 2, 3), new Vector3(2, 3, 4)));
        }
    }

}

