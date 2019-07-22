using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    private Vector3 movementDirection;
    public float speed;
    public float minSpeed;
    public float maxSpeed;
    public float minRandom;
    public float maxRandom;

    public Material deadMaterial; 

    [HideInInspector]
    public int lives = 2; 

    void Start () {

        float tempX = Random.Range(minRandom, maxRandom);
        float tempZ = Random.Range(minRandom, maxRandom);
        movementDirection = new Vector3(tempX, 0, tempZ);
        movementDirection.Normalize();
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void Update () {

        transform.position += (movementDirection * speed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("hit"); 
            //Destroy(gameObject.GetComponent<Player>());
        }
    }
}
