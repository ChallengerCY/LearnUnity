using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Set : MonoBehaviour
{
    // Start is called before the first frame update
    // Use this to set the new position of the GameObject
    Vector3 m_MyPosition;

    // Set an external Transform in the Inspector which is the GameObject’s starting point
    public Transform m_NewTransform;

    void Start()
    {
        // Set the new Vector to be that of the Transform you attach in the Inspector
        m_MyPosition.Set(m_NewTransform.position.x, m_NewTransform.position.y, 0);
    }

    void OnGUI()
    {
        // Press the Button to set the GameObject to this new position
        if (GUI.Button(new Rect(0, 0, 100, 40), "Set"))
        {
            transform.position = m_MyPosition;
        }
    }
}
