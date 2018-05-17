using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text distanceUpText;
    public Text nearestPlanetText;
    public float kmUp = 0;
    public float distanceFromNearestPlanet;
    public float[] distanceFromArray = {41400000f, 78340000f, 91691000f, 628730000f, 1275000000f, 2723950000f, 4351400000f, 41343390000000f };
    public string[] planetName = { "Venus", "Mars", "Mercury", "Jupiter", "Saturn", "Uranus", "Neptune", "Alpha Centauri" };
    public int distanceCount = 0;
    public int multValue = 50000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float actualDistanceFromPlanet = distanceFromArray[distanceCount] - kmUp;
        kmUp += GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp * multValue * Time.deltaTime;
        string kmUpString = kmUp.ToString("n3");
        nearestPlanetText.text = "Nearest Planet: " + planetName[distanceCount] + "\nDistance Remaining: " +  actualDistanceFromPlanet;
        distanceUpText.text = "Distance: " + kmUpString + " KM";

        if (kmUp >= distanceFromArray[distanceCount])
        {
            distanceCount++;
        }


	}
}
