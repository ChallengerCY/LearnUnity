using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformTranslate : MonoBehaviour
    {
        void Update()
        {
            // Move the object forward along its z axis 1 unit/second.
            // transform.Translate(Vector3.forward * Time.deltaTime);

            // Move the object upward in world space 1 unit/second.
           // transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
            
            // Move the object forward along its z axis 1 unit/second.
           // transform.Translate(0, 0, Time.deltaTime);

            // Move the object upward in world space 1 unit/second.
            //transform.Translate(0, Time.deltaTime, 0, Space.World);
            
            transform.Translate(Vector3.right * Time.deltaTime, Camera.main.transform);
            
            //transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);
        }
    }
}
