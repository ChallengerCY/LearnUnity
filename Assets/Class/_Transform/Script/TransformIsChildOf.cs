using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformIsChildOf : MonoBehaviour
    {
        void OnTriggerEnter(Collider col)
        {
            // Ignore trigger events if between this collider and colliders in children
            // Eg. when you have a complex character with multiple triggers colliders.
            if (col.transform.IsChildOf(transform))
            {
                return;
            }

            print("Do something here");
        }
    }
}
