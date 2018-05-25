using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text distanceUpText;
    public Text nearestPlanetText;
    public Text shieldText;
    public Text speedText;
    public float kmUp = 4341400000f;
    public float distanceFromNearestPlanet;
    public float[] distanceFromArray = {41400000f, 78340000f, 91691000f, 628730000f, 1275000000f, 2723950000f, 4351400000f};
    public string[] planetName = { "Venus", "Mars", "Mercury", "Jupiter", "Saturn", "Uranus", "Neptune"};
    public int distanceCount = 0;
    public long multValue = 50000;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float actualDistanceFromPlanet = distanceFromArray[distanceCount] - kmUp;
        kmUp += GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp * multValue * Time.deltaTime;
        string kmUpString = kmUp.ToString("n3");
        nearestPlanetText.text = "Nearest Planet: \n" + planetName[distanceCount] + "\n\nDistance Remaining: \n" +  actualDistanceFromPlanet;
        distanceUpText.text = "       Distance: \n" + kmUpString + " KM";
        speed = GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp * 300;
        speedText.text = "Speed: \n" + speed;
        if (kmUp >= distanceFromArray[distanceCount] && distanceCount < 6)
        {
            distanceCount++;
        }

        if (kmUp >= 4351400000f)
        {
            nearestPlanetText.text = "Beyond Neptune";
        }

        if (GameObject.Find("Player").GetComponent<PlayerManager>().isShielded == true)
        {
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 1)
            {
                shieldText.text = "Shield: l l l l l l";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 2 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 1)
            {
                shieldText.text = "Shield: l l l l l";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 3 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 2)
            {
                shieldText.text = "Shield: l l l l";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 4 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 3)
            {
                shieldText.text = "Shield: l l l";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 5 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 4)
            {
                shieldText.text = "Shield: l l";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 6 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 5)
            {
                shieldText.text = "Shield: l ";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 7 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 6)
            {
                shieldText.text = "Shield: ";
            }

        }
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isShielded == false)
        {
            shieldText.text = "Shield Inactive";
        }



	}
}
