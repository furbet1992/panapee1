using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=5;
    public float rotationalSpeed = 0.01f;
    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + transform.forward * speed; 
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + transform.forward * -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed, 0, 0);
            //transform.Rotate(transform.up * rotationalSpeed); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-speed, 0, 0);
            //transform.Rotate(transform.up * -rotationalSpeed);
        }



    }
}
