using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Class._Transform.Script
{
    public class TransformTransformPoint : MonoBehaviour
    {
        public GameObject someObject;
        public Vector3 thePosition;

        void Start()
        {
            // Instantiate an object to the right of the current object
            thePosition = transform.TransformPoint(Vector3.right * 2);
            Instantiate(someObject, thePosition, someObject.transform.rotation);
            
            
            Debug.LogError(transform.TransformVector(transform.position));
            Debug.LogError(transform.TransformDirection(transform.position));
        }
    }
}
