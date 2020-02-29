using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformInverseTransformDirection : MonoBehaviour
    {
        void Start()
        {
            // transform the world forward into local space:
            Vector3 relative;
            relative = transform.InverseTransformDirection(Vector3.forward);
            Debug.Log(relative);
        }

    }
}
