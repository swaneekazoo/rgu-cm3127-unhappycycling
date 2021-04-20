using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMonitor : MonoBehaviour {
	
	//SETUP
	
	//Variables
	public string current;
	
	
	
	//INITIALISATION
	
	void Awake () {
		
		//Get the current scene
		Scene scene = SceneManager.GetActiveScene();
		current = scene.name;
		Debug.Log("DIRECTOR: Current scene is " + current);
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
	}
	
}