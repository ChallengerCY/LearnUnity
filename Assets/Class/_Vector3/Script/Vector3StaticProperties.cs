using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Class._Vector3.Script
{
    public class Vector3StaticProperties : MonoBehaviour
    {

        public Vector3StaticPropertiesEnum currentVector3Properties;

        // Start is called before the first frame update
       void Start()
        {
            switch (currentVector3Properties)
            {
                case Vector3StaticPropertiesEnum.Back:
                    Debug.Log(Vector3.back);
                    break;
                case Vector3StaticPropertiesEnum.Down:
                    Debug.Log(Vector3.down);
                    break;
                case Vector3StaticPropertiesEnum.Forward:
                    Debug.Log(Vector3.forward);
                    break;
                case Vector3StaticPropertiesEnum.Left:
                    Debug.Log(Vector3.left);
                    break;
                case Vector3StaticPropertiesEnum.NegativeInfinity:
                    Debug.Log(Vector3.negativeInfinity);
                    break;
                case Vector3StaticPropertiesEnum.One:
                    Debug.Log(Vector3.one);
                    break;
                case Vector3StaticPropertiesEnum.PositiveInfinity:
                    Debug.Log(Vector3.positiveInfinity);
                    break;
                case Vector3StaticPropertiesEnum.Right:
                    Debug.Log(Vector3.right);
                    break;
                case Vector3StaticPropertiesEnum.Up:
                    Debug.Log(Vector3.up);
                    break;
                case Vector3StaticPropertiesEnum.Zero:
                    Debug.Log(Vector3.zero);
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

    /// <summary>
    /// 属性枚举
    /// </summary>
    public enum Vector3StaticPropertiesEnum
    {
        Back,	
        Down,
        Forward,
        Left,	
        NegativeInfinity,
        One,
        PositiveInfinity,	
        Right,
        Up,
        Zero,
    }
}
