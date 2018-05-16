using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Transform myT;
    public int speedUp = 4;
    public int speedHor = 7;
    int maxHorRight = 9;
    int maxHorLeft = -9;
    Vector3 resetPoint;
    Quaternion resetRotation;
    // Use this for initialization
    void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void Update () {
        resetPoint.x = myT.position.x;
        resetPoint.y = 10;
        resetPoint.z = 0;

        resetRotation.x = 0;
        resetRotation.y = 0;
        resetRotation.z = 0;

        float x = Input.GetAxisRaw("Horizontal");
        
        if (myT.position.x <= maxHorRight && x < 0)
        {
            transform.Translate(x * Time.deltaTime * -speedHor, 0, 0);
        }

        if (myT.position.x >= maxHorLeft && x > 0)
        {
            transform.Translate(x * Time.deltaTime * -speedHor, 0, 0);
        }



        transform.Translate(0, speedUp * Time.deltaTime, 0);

        if (myT.position.y >= 180)
        {
            myT.SetPositionAndRotation(resetPoint, resetRotation);
        }
    }
}
