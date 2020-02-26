using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3Constructor : MonoBehaviour
    {
        Vector3 myVector;
        Rigidbody m_Rigidbody;
        float m_Speed = 2.0f;

        void Start()
        {
            //Set the vector, which you use to move the RigidBody upwards straight away
            myVector = new Vector3(0.0f, 1.0f, 0.0f);
            //Fetch the RigidBody you attach to the GameObject
            m_Rigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            //Move the RigidBody upwards at the speed you define
            m_Rigidbody.velocity = myVector * m_Speed;
        }
    }
}


