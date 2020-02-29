using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformUp : MonoBehaviour
    {
        Rigidbody m_Rigidbody;
        float m_Speed;

        void Start()
        {
            //Fetch the Rigidbody component you attach from your GameObject
            m_Rigidbody = GetComponent<Rigidbody>();
            //Set the speed of the GameObject
            m_Speed = 10.0f;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Move the Rigidbody upwards constantly at speed you define (the green arrow axis in Scene view)
                m_Rigidbody.velocity = transform.up * m_Speed;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                //Move the Rigidbody downwards constantly at the speed you define (the green arrow axis in Scene view)
                m_Rigidbody.velocity = -transform.up * m_Speed;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //rotate the sprite about the Z axis in the positive direction
                transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * m_Speed, Space.World);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                //rotate the sprite about the Z axis in the negative direction
                transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * m_Speed, Space.World);
            }
        }
    }
}


