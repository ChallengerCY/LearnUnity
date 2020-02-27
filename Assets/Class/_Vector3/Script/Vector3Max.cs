using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Class._Vector3.Script
{
    public class Vector3Max : MonoBehaviour
    {
        // Start is called before the first frame update
        public Vector3 a = new Vector3(1, 2, 3);
        public Vector3 b = new Vector3(4, 3, 2);

        private void Start()
        {
            Debug.LogError("返回两个向量例每个属性的最大值");
            Example();
        }

        void Example()
        {
            print(Vector3.Max(a, b)); // prints (4.0f, 3.0f, 3.0f)
        }
    }
}
