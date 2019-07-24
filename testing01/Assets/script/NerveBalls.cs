using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerveBalls : MonoBehaviour
{
    public int nerveValue;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Enemy")
        {
            GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("enemyHit"); 
        }

        if (other.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.white;
        }

    }
}

