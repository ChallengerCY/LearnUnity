using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Class._Vector3.Script
{
    public class Vector3ToString : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // let Unity show these as (1.0, 2.0, 3.0)
            Vector3 vector = new Vector3(1, 2, 3);
            Debug.Log(vector.ToString());

            // unity sadly decides (1.2, 5.7, 9.0)
            vector = new Vector3(1.234f, 5.678f, 9.012f);
            Debug.Log(vector.ToString());

            // but we can show this using format - 3 numbers after the decimal point
            // (1.234, 5.678, 9.012)
            Debug.Log(vector.ToString("F3"));

            // now let's create some longer numbers
            vector = new Vector3(1.0f / 3.0f, -Mathf.PI, Mathf.Exp(-2.0f));

            // we get (0.333333, -3.141593, 0.135335)
            //fractional part 小数部分
            Debug.Log("fractional part is 6: " + vector.ToString("F6"));

            // note how F8 cannot display these numbers as we want
            // (0.33333330, -3.14159300, 0.13533530)
            Debug.Log("fractional part is 8: " + vector.ToString("F8"));
        }
    }
}


