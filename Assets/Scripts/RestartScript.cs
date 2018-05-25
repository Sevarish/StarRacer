using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadLevel()
    {
        Application.LoadLevel("MainScene");
    }
    public void LoadMainMenu()
    {
        Application.LoadLevel("StartScreen");
    }
}
