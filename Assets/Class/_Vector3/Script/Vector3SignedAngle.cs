using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3SignedAngle : MonoBehaviour
    {
        public Transform target;

        void Update()
        {
            Vector3 targetDir = target.position - transform.position;
            Vector3 forward = transform.forward;
            float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);
            
            Debug.LogError(angle);
            if (angle < -5.0F)
                print("turn left");
            else if (angle > 5.0F)
                print("turn right");
            else
                print("forward");
        }
    }
}


