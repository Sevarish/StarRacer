using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject Asteroid1;
    public GameObject Asteroid2;
    public GameObject Asteroid3;
    public GameObject Satalite;
    public float spawnThreshold = 0.8f;
    Vector3 spawnPos;
    private float spawnTimer = 0;


    private void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
           

        }


    }
   

        private void SpawnCube()
    {
        spawnPos.x = -30;
        spawnPos.y = Random.Range(30f, 160f);
        spawnPos.z = -3.47f;
        int rand = Random.Range(1, 4);
 
        if (rand == 1)
        {
            Instantiate(Asteroid1, spawnPos, Quaternion.identity);
        }
        if (rand == 2)
        {
            Instantiate(Asteroid2, spawnPos, Quaternion.identity);
        }
        if (rand == 3)
        {
            Instantiate(Satalite, spawnPos, Quaternion.identity);
        }
        if (rand == 4)
        {
            Instantiate(Asteroid3, spawnPos, Quaternion.identity);
        }
        spawnTimer = 0;


    }

}
