using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._CapsuleCollider.Script
{
    public class CapsuleColliderProperties : MonoBehaviour
    {

        public CapsuleCollider CapsuleCollider;
        // Start is called before the first frame update
        void Start()
        {
            CapsuleCollider = GetComponent<CapsuleCollider>();
            Debug.LogError($"中心点{CapsuleCollider.center}");
            Debug.LogError($"胶囊体方向{CapsuleCollider.direction}");
            Debug.LogError($"胶囊半径{CapsuleCollider.radius}");
            Debug.LogError($"胶囊高度{CapsuleCollider.height}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
