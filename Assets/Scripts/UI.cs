using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text distanceUpText;
    public float kmUp = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        kmUp += GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp * 1000 * Time.deltaTime;
        distanceUpText.text = "Distance: " + kmUp + " KM";
	}
}
