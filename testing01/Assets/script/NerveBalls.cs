using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerveBalls : MonoBehaviour
{
    public int nerveValue;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            nerveValue += 1;
            Debug.Log(nerveValue);
            Destroy(gameObject);
        }

    }
}
