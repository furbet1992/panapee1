using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBall : MonoBehaviour
{
    public int orbitSpeed = 80;

    void Update()
    {
        Orbiting();
        
    }

    void Orbiting()
    {
        transform.Rotate(Vector3.up * orbitSpeed * Time.deltaTime);
    }
    



}
