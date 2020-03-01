using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDemo : MonoBehaviour
{
    
    public Transform explosionPrefab;
    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);
        
      
        Debug.LogError(collision.transform.name);
        
    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionStay(Collision collision)
    {
        
        Debug.LogError($"当前的冲量是{collision.impulse}");
        
        Debug.LogError($"当前的相对速度是{collision.relativeVelocity}");
        
        
        
        //Check to see if the Collider's name is "Chest"
        if (collision.collider.name == "Chest")
        {
            //Output the message
            Debug.Log("Chest is here!");
        }
        
        if (collision.rigidbody)
        {
            collision.rigidbody.AddForce(Vector3.left * 15);
        }
        
        Debug.LogError($"接触数量是{collision.contactCount}");
        
        
        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            // Visualize the contact point
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        
        Debug.LogError($"使用GetContacts方法：{collision.GetContacts(collision.contacts)}");
        
        ContactPoint contact1 = collision.GetContact(0);
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact1.normal);
        Vector3 pos = contact1.point;
        Instantiate(explosionPrefab, pos, rot);
       // Destroy(gameObject);
    }
}
