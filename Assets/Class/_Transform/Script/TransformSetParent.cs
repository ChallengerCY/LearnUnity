using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformSetParent : MonoBehaviour
    {
        public GameObject child;

        public Transform parent;

        private void Start()
        {
            Example(parent);
        }

        //Invoked when a button is clicked.
        public void Example(Transform newParent)
        {
            // Sets "newParent" as the new parent of the child GameObject.
            //child.transform.SetParent(newParent);

            // Same as above, except worldPositionStays set to false
            // makes the child keep its local orientation rather than
            // its global orientation.
           child.transform.SetParent(newParent, false);

            // Setting the parent to ‘null’ unparents the GameObject
            // and turns child into a top-level object in the hierarchy
           // child.transform.SetParent(null);
           
        //   Debug.LogError($"同时设置{parent.SetPositionAndRotation}");
           parent.SetPositionAndRotation(new Vector3(0,0,0), Quaternion.identity);
        }
    }
}
