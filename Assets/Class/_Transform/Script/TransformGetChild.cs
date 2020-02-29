using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformGetChild : MonoBehaviour
    {
        public Transform meeple;
        public GameObject grandChild;

        private void Start()
        {
            Example();
        }

        public void Example()
        {
            //Assigns the transform of the first child of the Game Object this script is attached to.
            meeple = this.gameObject.transform.GetChild(0);

            //Assigns the first child of the first child of the Game Object this script is attached to.
            grandChild = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
        }
    }
}


