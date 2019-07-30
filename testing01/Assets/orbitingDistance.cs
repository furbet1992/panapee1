using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitingDistance : MonoBehaviour
{



    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
         {
            transform.localPosition = transform.localPosition + new Vector3(0, 0, 0.1f);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.localPosition = transform.localPosition - new Vector3(0, 0, 0.1f);
        }

    }
}
