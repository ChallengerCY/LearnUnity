using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3StaticPropertiesOfficialDemo : MonoBehaviour
    {
        
        public Vector3StaticPropertiesEnum currentVector3Properties;
        // Update is called once per frame
        void Update()
        {
            switch (currentVector3Properties)
            {
                case Vector3StaticPropertiesEnum.Back:
                    transform.position += Vector3.back * Time.deltaTime;
                    break;
                case Vector3StaticPropertiesEnum.Down:
                    transform.position += Vector3.down * Time.deltaTime;
                    break;
                case Vector3StaticPropertiesEnum.Forward:
                    transform.position += Vector3.forward * Time.deltaTime;
                    break;
                case Vector3StaticPropertiesEnum.Left:
                    transform.position += Vector3.left * Time.deltaTime;
                    break;
                case Vector3StaticPropertiesEnum.One:
                    //演示使用，不推荐放到update
                    transform.position = Vector3.one;
                    break;
                case Vector3StaticPropertiesEnum.Right:
                    transform.position += Vector3.right * Time.deltaTime;
                    break;
                case Vector3StaticPropertiesEnum.Up:
                    transform.position += Vector3.up * Time.deltaTime;
                    break;
                case Vector3StaticPropertiesEnum.Zero:
                    //演示使用，不推荐放到update
                    transform.position = Vector3.zero;
                    break;
                default:
                    Debug.LogError($"暂时没有{currentVector3Properties} API的例子");
                    break;
            }
        }
    }
}
