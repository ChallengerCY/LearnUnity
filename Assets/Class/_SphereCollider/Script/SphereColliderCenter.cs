using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._SphereCollider.Script
{
    public class SphereColliderCenter : MonoBehaviour
    {
        public SphereCollider SphereCollider;
        // Start is called before the first frame update
        void Start()
        {
            Debug.LogError(SphereCollider.center);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}


