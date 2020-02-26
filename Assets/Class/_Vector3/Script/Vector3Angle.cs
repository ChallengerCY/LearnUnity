using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Class._Vector3.Script
{
    public class Vector3Angle : MonoBehaviour
    {
        public Transform target;

        // prints "close" if the z-axis of this transform looks
        // almost towards the target

        void Update()
        {
            //算出指向目标的向量
            Vector3 targetDir = target.position - transform.position;
            //求当前物体前方和指向目标的向量的夹角

            float angle = Vector3.Angle(targetDir, transform.forward);

            if (angle < 5.0f)
                print("close");

            //todo 可以补充一个划线，使例子更详细
        }
    }
}
