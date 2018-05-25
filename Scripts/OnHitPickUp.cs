using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitPickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {


            GameObject.Find("Player").GetComponent<PlayerManager>().isShielded = true;
            GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer = 0;
            GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp += 20;
            GameObject.Find("SpawnPowerups").GetComponent<PowerupsSpawn>().isPickedUp = true;
            GameObject.Find("SpawnPowerups").GetComponent<PowerupsSpawn>().pickUpTimer = 0;

            Destroy(this.gameObject);

        }
    }

    
}

