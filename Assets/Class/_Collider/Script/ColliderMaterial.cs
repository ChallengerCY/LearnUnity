using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Collider.Script
{
    public class ColliderMaterial : MonoBehaviour
    {
        // Expose properties in the inspector for easy adjustment.
        /// <summary>
        /// 动态摩擦力
        /// </summary>
        public float dynFriction;

        /// <summary>
        /// 静态摩擦力
        /// </summary>
        public float statFriction;

        Collider coll;

        void Start()
        {
            coll = GetComponent<Collider>();

            //调用属性的时候自动生成physicsMaterial，如果没有的话
            coll.material.dynamicFriction = dynFriction;
            coll.material.staticFriction = statFriction;
            
            //如果没有physicsMaterial会报null
            coll.sharedMaterial.dynamicFriction = dynFriction;
            coll.sharedMaterial.staticFriction = statFriction;
        }
    }
}