using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactPointProperties : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        print("Points colliding: " + other.contacts.Length);
        print("First normal of the point that collide: " + other.contacts[0].normal);
        print("First point that collided: " + other.contacts[0].point);
        
        print("分离距离是" + other.contacts[0].separation);
        Debug.LogError(other.gameObject.name);
        Debug.LogError(other.contacts[0].otherCollider.name);
        Debug.LogError(other.contacts[0].thisCollider.name);
    }
}
