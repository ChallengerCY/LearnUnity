using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3Distance : MonoBehaviour
    {
        
       // Returns the distance between a and b.
       // Vector3.Distance(a,b) is the same as (a-b).magnitude.
        
        // Start is called before the first frame update
        public Transform other;

        void Update()
        {
            if (other)
            {
                float dist = Vector3.Distance(other.position, transform.position);
                print("Distance to other: " + dist);
            }
        }
    }

}

