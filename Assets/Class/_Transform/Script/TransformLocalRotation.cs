using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformLocalRotation : MonoBehaviour
    {
        private float x;
        private float z;
        private bool rotateX;
        private float rotationSpeed;

        void Start()
        {
            x = 0.0f;
            z = 0.0f;
            rotateX = true;
            rotationSpeed = 75.0f;
            Example();
        }
        
        void Example()
        {
            transform.localRotation = Quaternion.identity;
        }

        void FixedUpdate()
        {
            if (rotateX)
            {
                x += Time.deltaTime * rotationSpeed;

                if (x > 360.0f)
                {
                    x = 0.0f;
                    rotateX = false;
                }
            }
            else
            {
                z += Time.deltaTime * rotationSpeed;

                if (z > 360.0f)
                {
                    z = 0.0f;
                    rotateX = true;
                }
            }

            transform.localRotation = Quaternion.Euler(x, 0, z);
        }
    }
}
