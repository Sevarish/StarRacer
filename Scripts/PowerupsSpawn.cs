using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupsSpawn : MonoBehaviour {
    public GameObject shieldPowerUp;
    Vector3 spawnPos;
    GameObject[] go;
    public bool isPickedUp = true;
    public float pickUpTimer = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


        spawnPos.x = Random.Range(-9, 9);
        spawnPos.y = Random.Range(30, 160);
        spawnPos.z = -3.47f;
        go = GameObject.FindGameObjectsWithTag("Powerup");

        if (isPickedUp == true)
        {
            pickUpTimer += Time.deltaTime;
        }
        if (go.Length < 2 && pickUpTimer > 30)
        {
            Instantiate(shieldPowerUp, spawnPos, Quaternion.identity);
        }
    }
}
