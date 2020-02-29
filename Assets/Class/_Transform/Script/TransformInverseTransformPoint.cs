using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformInverseTransformPoint : MonoBehaviour
    {
        public Transform cam;
        public Vector3 cameraRelative;

        void Start()
        {
            cam = Camera.main.transform;
            Vector3 cameraRelative = cam.InverseTransformPoint(transform.position);

            Debug.LogError(cameraRelative);

            if (cameraRelative.z > 0)
                print("The object is in front of the camera");
            else
                print("The object is behind the camera");
        }
    }
}
