using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformFind : MonoBehaviour
    {
        public GameObject player;
        public GameObject gun;
        public Transform ammo;

        private void Start()
        {
            Example();
        }

        //Invoked when a button is clicked.
        public void Example()
        {
            //Finds and assigns the child of the player named "Gun".
            gun = player.transform.Find("Gun").gameObject;

            //If the child was found.
            if (gun != null)
            {
                //Find the child named "ammo" of the gameobject "magazine" (magazine is a child of "gun").
                ammo = gun.transform.Find("magazine/ammo");
            }
            else Debug.Log("No child with the name 'Gun' attached to the player");
        }
    }
}
