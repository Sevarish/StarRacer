using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
    Transform myT;
    public float speed = 20f;
    int counter = 0;
    
	// Use this for initialization
	void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void Update () {
        myT.Translate(speed * Time.deltaTime, 0, 0);
        counter++;
        if (counter >= 600)
        {
            Destroy(this.gameObject);
        }
        myT.Rotate(0,0,Random.Range(-360, 360) * Time.deltaTime);
	}
}
