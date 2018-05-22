using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Transform myT;
    public float speedUp = 4;
    public int speedHor = 7;
    int maxHorRight = 9;
    int maxHorLeft = -9;
    int yPosition = 0;
    public Vector3 resetPoint;
    public Quaternion resetRotation;
    public bool maxHeightReached = false;
    // Use this for initialization
    void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void Update () {
        resetPoint.x = myT.position.x;
        resetPoint.y = 10;
        resetPoint.z = myT.position.z;

        resetRotation.x = 0;
        resetRotation.y = 0;
        resetRotation.z = 0;





        float x = Input.GetAxisRaw("Horizontal");
        Debug.Log(x);
        float y = Input.GetAxisRaw("Vertical");

        if (myT.position.x <= maxHorRight && x < 0)
        {
            
            transform.Translate(x * Time.deltaTime * -speedHor, 0, 0);
        }

        if (myT.position.x >= maxHorLeft && x > 0)
        {
            
            transform.Translate(x * Time.deltaTime * -speedHor, 0, 0);
        }

        if (y > 0 && yPosition <= 60)
        {
            float actualY = y / 10; 
            yPosition++;
            transform.Translate(0 ,actualY, 0);
        }

        if (y < 0 && yPosition >= -60)
        {
            float actualY = y / 10;
            yPosition--;
            transform.Translate(0, actualY, 0);
        }

        


        if (maxHeightReached == true)
        {
            
            speedUp += 0.2f;

            if (GameObject.Find("Player").GetComponent<UI>().distanceCount < 2)
            {
                GameObject.Find("Player").GetComponent<UI>().multValue += 28000;
            }
            else
            {
                GameObject.Find("Player").GetComponent<UI>().multValue += 1500000;
            }

            maxHeightReached = false;
        }

        

    }
}
