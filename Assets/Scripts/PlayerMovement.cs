using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Transform myT;
    public int speedUp = 4;
    public int speedHor = 7;
    int maxHorRight = 9;
    int maxHorLeft = -9;
	// Use this for initialization
	void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void Update () {
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
    }
}
