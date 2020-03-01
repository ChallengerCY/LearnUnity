using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._SphereCollider.Script
{
    public class SphereColliderRadius : MonoBehaviour
    {
    
        //This declares your SphereCollider
        SphereCollider myCollider;

        void Start()
        {
            //Assigns the attached SphereCollider to myCollider
            myCollider = GetComponent<SphereCollider>();
            myCollider.radius += 2f;
        }

        void OnTriggerEnter(Collider other)
        {
            //This increases the Collider radius when the GameObject collides with a trigger Collider
            myCollider.radius += 2f;
        }
    }
}


