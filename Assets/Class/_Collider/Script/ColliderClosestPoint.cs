using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Collider.Script
{
    public class ColliderClosestPoint : MonoBehaviour
    {
        public Vector3 location;

        public void OnDrawGizmos()
        {
            var collider = GetComponent<Collider>();

            if (!collider)
            {
                return; // nothing to do without a collider
            }

            Vector3 closestPoint = collider.ClosestPoint(location);

            Debug.Log($"包围盒离目标点最近的点是{closestPoint}");
            Gizmos.DrawSphere(location, 0.1f);
            Gizmos.DrawWireSphere(closestPoint, 0.1f);
        }
    }
}
