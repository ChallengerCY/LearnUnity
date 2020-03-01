using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Collider.Script
{
    public class ColliderAttachedRigidbody : MonoBehaviour
    {
        void Start()
        {
            // Lift the rigidbody attached to the collider.
            GetComponent<Collider>().attachedRigidbody.AddForce(0, 10, 0);
        } 
    
    }

}

