using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{
    public class Vector3Cross : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
           Debug.LogError(@"求两个向量的叉积,两个向量的叉积生成第三个向量，
           该向量垂直于两个输入向量。结果的大小等于：
           将两个输入的大小相乘，然后乘以输入之间角度的正弦值。
           可以使用“左手规则”确定结果向量的方向。");
           
           Debug.Log(GetNormal(Vector3.zero,Vector3.right,Vector3.up));
        }
        
        /// <summary>
        /// 获取叉积
        /// </summary>
        /// <param name="a">中间向量</param>
        /// <param name="b">目标向量b</param>
        /// <param name="c">目标向量c</param>
        /// <returns></returns>
        Vector3 GetNormal(Vector3 a, Vector3 b, Vector3 c)
        {
            // Find vectors corresponding to two of the sides of the triangle.
            Vector3 side1 = b - a;
            Vector3 side2 = c - a;

            // Cross the vectors to get a perpendicular vector, then normalize it.
            return Vector3.Cross(side1, side2).normalized;
        }
    }
}


