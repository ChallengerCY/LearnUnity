using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Class._Transform.Script
{
    public class TransformHasChanged : MonoBehaviour
    {
        void Update()
        {
            if (transform.hasChanged)
            {
                print("The transform has changed!");
                transform.hasChanged = false;
                
                
            }
            
            Debug.LogError($"当前节点的容量是{transform.hierarchyCapacity}");
            Debug.LogError($"当前节点的个数是是{transform.hierarchyCount}");
        }

    }
}
