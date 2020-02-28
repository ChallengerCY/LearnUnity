using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3Project : MonoBehaviour
    {
        public Transform Target;

        public Vector3 RailDirection;

        private void Update()
        {
            Slide(Target, RailDirection);
        }


        void Slide(Transform target, Vector3 railDirection)
        {
            Vector3 heading = target.position - transform.position;
            Vector3 force = Vector3.Project(heading, railDirection);

            GetComponent<Rigidbody>().AddForce(force);
        }
    }
}
