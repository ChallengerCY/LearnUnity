using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._MeshCollider.Script
{
    public class MeshColliderSharedMesh : MonoBehaviour
    {
       public Mesh meshToCollide;

        void Start()
        {
            if (!meshToCollide)
            {
                Debug.LogError("Assign a mesh in the inspector");
                return;
            }

            MeshCollider meshCollider = gameObject.AddComponent<MeshCollider>();
            meshCollider.sharedMesh = meshToCollide;

        }
    }
}


