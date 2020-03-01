using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Collider.Script
{
    public class ColliderOnCollision : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            foreach (ContactPoint contact in other.contacts)
            {
                Debug.DrawRay(contact.point, contact.normal, Color.white);
            }
        }

        private void OnCollisionStay(Collision other)
        {
            foreach (ContactPoint contact in other.contacts)
            {
                Debug.DrawRay(contact.point, contact.normal * 10, Color.white);
            }
        }

        private void OnCollisionExit(Collision other)
        {
            print("No longer in contact with " + other.transform.name);
        }
    }
}
