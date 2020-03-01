using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Collider.Script
{
    public class ColliderRaycast : MonoBehaviour
    {
        public Collider coll;

        void Start()
        {
            coll = GetComponent<Collider>();
        }

        void Update()
        {
            // Move this object to the position clicked by the mouse.
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (coll.Raycast(ray, out hit, 100.0f))
                {
                    transform.position = ray.GetPoint(100.0f);
                }
            }
        }
    }
}
