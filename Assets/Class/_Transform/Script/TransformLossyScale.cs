using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
{
    public class TransformLossyScale : MonoBehaviour
    {
      
        void Start()
        {
            print(transform.lossyScale);
            print(transform.localScale);
        }
    }
}
