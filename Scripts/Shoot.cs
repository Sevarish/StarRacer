using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject Rocket;
    public GameObject Rocket1;
    public GameObject Rocket_Emitter;
    public float Rocket_Force;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isShielded == true)
        {
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Rocket, Rocket_Emitter.transform.position, Rocket_Emitter.transform.rotation) as GameObject;
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Temporary_RigidBody.AddForce(transform.up * -Rocket_Force);
            Destroy(Temporary_Bullet_Handler, 0.05f);
        }
        else
        {
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Rocket1, Rocket_Emitter.transform.position, Rocket_Emitter.transform.rotation) as GameObject;
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Temporary_RigidBody.AddForce(transform.up * -Rocket_Force);
            Destroy(Temporary_Bullet_Handler, 0.06f);
        }

    }
}
