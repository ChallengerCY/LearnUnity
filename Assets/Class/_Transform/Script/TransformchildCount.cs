﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Transform.Script
 {
    public class TransformchildCount : MonoBehaviour
    {
        // generate a group of connected GameObjects
        void Awake()
        {
            GameObject go = new GameObject("top");

            //重新生成随机数种子
            Random.InitState(System.Environment.TickCount);

            // add 3, 4 or 5 "middle" children that report to "top"
            for (int i = 0; i < Random.Range(3, 6); i++)
            {
                GameObject go2 = new GameObject("middle" + i.ToString());
                go2.transform.parent = go.transform;

                // add between 1 to 8 "bottom" children that report to the above "middle"
                for (int j = 0; j < Random.Range(1, 8); j++)
                {
                    GameObject go3 = new GameObject("bottom" + j);
                    go3.transform.parent = go2.transform;
                }
            }
        }

        void Start()
        {
            // how many children does top have?
            GameObject go = GameObject.Find("top");
            Debug.Log(go.name + " has " + go.transform.childCount + " children");

            // pick a random middle group and pick a member of its children
            go = GameObject.Find("middle" + Random.Range(0, go.transform.childCount));
            Debug.Log(go.name + " has " + go.transform.childCount + " children");
        }
    }

}