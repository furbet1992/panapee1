using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingGun : MonoBehaviour
{
    public  GameObject projectilePoint;
    public GameObject projectile;
    public float projectileSpeed; 



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Go = Instantiate(projectile, projectilePoint.transform.position, Quaternion.identity) as GameObject;
            Go.GetComponent<Rigidbody>().AddForce(projectilePoint.transform.forward * projectileSpeed, ForceMode.Impulse);
          
        }

    }
}
