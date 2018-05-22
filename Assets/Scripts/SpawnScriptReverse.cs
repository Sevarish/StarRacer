using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScriptReverse : MonoBehaviour
{

    public GameObject cubePrefab;
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
        spawnPos.x = 30;
        spawnPos.y = Random.Range(30f, 160f);
        spawnPos.z = -3.47f;
        Instantiate(cubePrefab, spawnPos, Quaternion.identity);
        spawnTimer = 0;


    }

}
