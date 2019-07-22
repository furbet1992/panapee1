using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerveMachine : MonoBehaviour
{
    private NerveBalls required; 
    public GameObject door;
    public GameObject sphere; 
 

    void Start()
    {
       
        required= sphere.GetComponent<NerveBalls>();
       

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) 
    {
       if  ((other.tag == "Player") && (required.nerveValue ==1))
        {
            Debug.Log("door"); 
            door.SetActive(false); 
        }

        
    }
}
