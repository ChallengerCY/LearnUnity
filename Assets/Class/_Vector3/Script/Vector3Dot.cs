using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3Dot : MonoBehaviour
    {
        // Start is called before the first frame update
        public Transform other;

        private void Start()
        {
            Debug.LogError(@"点积是一个浮点值，它等于将两个向量的大小相乘，然后乘以向量之间角度的余弦值。
                                对于 normalized 向量，如果它们指向完全相同的方向，Dot 返回 1；
                                如果它们指向完全相反的方向，返回 -1；如果向量彼此垂直，则 Dot 返回 0。");
        }

        void Update()
        {
            if (other)
            {
                Vector3 forward = transform.TransformDirection(Vector3.forward);
                Vector3 toOther = other.position - transform.position;

                if (Vector3.Dot(forward, toOther) < 0)
                {
                    print("The other transform is behind me!");
                }
            }
        }
    }
}


