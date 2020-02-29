using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._BoxCollider.Script
{
    public class BoxColliderCenter : MonoBehaviour
    {
        public BoxCollider BoxCollider;
        // Start is called before the first frame update
        void Start()
        {
            Debug.LogError(BoxCollider.center);
        }

    }
}
