using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3ClampMagnitude : MonoBehaviour
    {
        public Vector3 centerPt;
        public float radius;

        private void Start()
        {
            Debug.LogError("以centerPt为圆心，半径为radius 的范围内移动物体");
        }

        void Update()
        {
            // Get the new position for the object.
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
           
            Vector3 newPos = transform.position + movement;

            // Calculate the distance of the new position from the center point. Keep the direction
            // the same but clamp the length to the specified radius.
            Vector3 offset = newPos - centerPt;
            //以centerPt为圆心，半径为radius 的范围内移动物体
            transform.position = centerPt + Vector3.ClampMagnitude(offset, radius);
        }
    }
}