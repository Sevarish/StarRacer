using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticUpCamera : MonoBehaviour {
    Transform myT;
    float speed;
    Vector3 resetPoint;
	// Use this for initialization
	void Start () {
        resetPoint.x = 0;
        resetPoint.y = 10;
        resetPoint.z = 0;
        myT = transform;
        

    }
	
	// Update is called once per frame
	void Update () {
        speed = GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp;
        transform.Translate(0, speed * Time.deltaTime, 0);
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isShielded == true)
        {

        }

        if (GameObject.Find("Player").GetComponent<PlayerMovement>().maxHeightReached == true)
        {
            myT.SetPositionAndRotation(resetPoint, GameObject.Find("Player").GetComponent<PlayerMovement>().resetRotation);
            speed += 0.2f;
        }
    }
}
