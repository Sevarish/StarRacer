using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerate : MonoBehaviour {
    public GameObject obstacleBlock;
    Vector3 spawnZone;
    Quaternion spawnRot;
    float posY = 30;
    public GameObject _instance;
	// Use this for initialization
	void Start () {
        SpawnObstacles(30);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnObstacles(int obstacleAmount)
    {
        for (int i = 0; i < obstacleAmount; i++)
        {
 
            posY += 140/obstacleAmount;
            //Spawn XYZ rot
            spawnRot.x = 0;
            spawnRot.y = 0;
            spawnRot.z = 50;


            //Spawn XYZ pos
            spawnZone.x = Random.Range(-8f, 8f);
            spawnZone.y = posY;
            spawnZone.z = -3.42f;
            _instance = Instantiate(obstacleBlock, spawnZone, spawnRot);
        }
    }
}
