using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3SqrMagnitudeOfficialDemo : MonoBehaviour
    {
        public Transform other;
        public float closeDistance = 5.0f;

        private void Start()
        {
            Debug.LogError("比较两个物体是否接近，推荐使用sqrMagnitude，向量的平方长度，性能比较好");
        }

        void Update()
        {
            if (other)
            {
                Vector3 offset = other.position - transform.position;
                float sqrLen = offset.sqrMagnitude;

                // square the distance we compare with
                if (sqrLen < closeDistance * closeDistance)
                {
                    Debug.Log("The other transform is close to me!");
                }
            }
        }
    }
}


