using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3Properties : MonoBehaviour
    {

        public Vector3PropertiesEnum currentVector3PropertiesEnum;
        
        private Vector3 _vector3;
        // Start is called before the first frame update
        void Start()
        {
           _vector3=new Vector3(1,2,3);


           switch (currentVector3PropertiesEnum)
           {
               case Vector3PropertiesEnum.Magnitude:
                   Debug.Log($"向量{_vector3}的长度(magnitude)是{_vector3.magnitude}");
                   break;
               case Vector3PropertiesEnum.Normalized:
                   Debug.Log($"向量{_vector3}的标准化向量(Normalized)是{_vector3.normalized}");
                   break;
               case Vector3PropertiesEnum.SqrMagnitude:
                   Debug.Log($"向量{_vector3}的平方长度(SqrMagnitude)是{_vector3.sqrMagnitude}");
                   break;
               case Vector3PropertiesEnum.This:
                   Debug.Log($"向量{_vector3}的[0]是{_vector3[0]},代表x,[1]代表y,[2]代表z");
                   break;
               case Vector3PropertiesEnum.X:
                   Debug.Log($"向量{_vector3}的x是{_vector3.x},代表x");
                   break;
               case Vector3PropertiesEnum.Y:
                   Debug.Log($"向量{_vector3}的y是{_vector3.y},代表y");
                   break;
               case Vector3PropertiesEnum.Z:
                   Debug.Log($"向量{_vector3}的z是{_vector3.z},代表z");
                   break;
               default:
                   throw new ArgumentOutOfRangeException();
           }
          
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
    
    public enum Vector3PropertiesEnum
    {
        Magnitude,
        Normalized,
        SqrMagnitude,	
        This,	
        X,	
        Y,
        Z,
    }

}

