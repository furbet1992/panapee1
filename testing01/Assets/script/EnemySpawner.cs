using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyPrefab;

    private float counter = 0.0f;
    public float spawnTimer = 5.0f;

    private BoxCollider bc;
    private float tempX;
    private float tempZ;

    private void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    void Update()
    {
        counter += Time.deltaTime;

        if (counter >= spawnTimer)
        {
            tempX = Random.Range(-(bc.extents.x / 2), (bc.extents.x / 2));
            tempZ = Random.Range(-(bc.extents.x / 2), (bc.extents.x / 2));

            Vector3 tempVector = new Vector3(tempX, 0, tempZ);

            Instantiate(enemyPrefab, tempVector, Quaternion.identity);
            counter = 0.0f;
        }
    }
}
