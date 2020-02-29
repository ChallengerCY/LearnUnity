using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformLookAt : MonoBehaviour
    {
        public Transform target;

        void Update()
        {
            // Rotate the camera every frame so it keeps looking at the target
            //transform.LookAt(target);

            // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
            //transform.LookAt(target, Vector3.right);

            transform.LookAt(new Vector3(0, 0, 0));
        }
    }
}
