using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Ray.Script
{
    public class RayConstructor : MonoBehaviour
    {
        void Start()
        {
            // Create a ray from the transform position along the transform's z-axis
            Ray ray = new Ray(transform.position, transform.forward);

            Debug.LogError($"射线发出后10m的点是{ray.GetPoint(10)}");

            Debug.LogError($"描述当前射{ray.ToString()}");

            Debug.LogError($"射线的方向是{ray.direction}");

            Debug.LogError($"射线的起点是{ray.origin}");
        }
    }
}
