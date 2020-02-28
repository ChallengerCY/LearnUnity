using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Class._Vector3.Script
{
    public class Vector3Reflect : MonoBehaviour
    {
        public Transform originalObject;
        public Transform reflectedObject;

        void Update()
        {
            // Makes the reflected object appear opposite of the original object,
            // mirrored along the z-axis of the world

            Vector3 inDirection = Vector3.zero - new Vector3(-1, 0, 1);
            reflectedObject.position = Vector3.Reflect(inDirection,Vector3.up);
        }
    }

}

