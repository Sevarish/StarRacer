using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour {
    Transform myT;
    Quaternion myR;
    float speed = 0.08f;
    bool moveRight = true;
    bool moveLeft = false;
	// Use this for initialization
	void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (myT.position.x < 9 && moveRight == true)
        {
            myT.Translate(-speed, 0, 0);
        }

        if (myT.position.x > -9 && moveLeft == true)
        {
            myT.Translate(speed, 0, 0);
        }

        if (myT.position.x > 8)
        {
            moveRight = false;
            moveLeft = true;
        }

        if (myT.position.x < -8)
        {
            moveRight = true;
            moveLeft = false;
        }
        myR.z = Random.Range(-360, 360);
        myR.x = 0;
        myR.y = 0;
        myT.rotation = myR;
        
	}
}
