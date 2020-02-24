using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Class._Vector3.Script
{
    public class Vector3StaticProperties : MonoBehaviour
    {

        public Vector3Properties currentVector3Properties;
        
        // Start is called before the first frame update
       void Start()
        {
            switch (currentVector3Properties)
            {
                case Vector3Properties.Back:
                    Debug.Log(Vector3.back);
                    break;
                case Vector3Properties.Down:
                    Debug.Log(Vector3.down);
                    break;
                case Vector3Properties.Forward:
                    Debug.Log(Vector3.forward);
                    break;
                case Vector3Properties.Left:
                    Debug.Log(Vector3.left);
                    break;
                case Vector3Properties.NegativeInfinity:
                    Debug.Log(Vector3.negativeInfinity);
                    break;
                case Vector3Properties.One:
                    Debug.Log(Vector3.one);
                    break;
                case Vector3Properties.PositiveInfinity:
                    Debug.Log(Vector3.positiveInfinity);
                    break;
                case Vector3Properties.Right:
                    Debug.Log(Vector3.right);
                    break;
                case Vector3Properties.Up:
                    Debug.Log(Vector3.up);
                    break;
                case Vector3Properties.Zero:
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
    public enum Vector3Properties
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
