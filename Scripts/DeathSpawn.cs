using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpawn : MonoBehaviour {

    public GameObject Asteroid1;
    public GameObject Asteroid2;
    public GameObject Asteroid3;
    public GameObject Satalite;
    public float spawnThreshold = 0.6f;


    private float spawnTimer;



    private void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
            spawnTimer = 0;
        }


    }

    private void SpawnCube()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-8.0f, 8.0f), 15, -2);
        int rand = Random.Range(1, 5);
        if (rand == 1)
        {
            Instantiate(Asteroid1, spawnPosition, Quaternion.identity);
        }

        if (rand == 2)
        {
            Instantiate(Asteroid2, spawnPosition, Quaternion.identity);
        }

        if (rand == 3)
        {
            Instantiate(Asteroid3, spawnPosition, Quaternion.identity);
        }

        if (rand == 4)
        {
            Instantiate(Satalite, spawnPosition, Quaternion.identity);
        }




    }
}
