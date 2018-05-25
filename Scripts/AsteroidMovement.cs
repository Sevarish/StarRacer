using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
    Transform myT;
    public float speed;
    int counter = 0;
    bool doOnce = true;
    int count = 0;
	// Use this for initialization
	void Start () {
        myT = transform;
        speed =  6;

    }
	
	// Update is called once per frame
	void Update () {
        myT.Translate(speed * Time.deltaTime, 0, 0);
        counter++;
        if (counter >= 600)
        {
            Destroy(this.gameObject);
        }

        if (doOnce == true)
        {

            myT.Rotate(0, 0, Random.Range(-180, 180) * Time.deltaTime);
            
            if (count > 20)
            {
                doOnce = false;
            }
            count++;
        }
	}
}
