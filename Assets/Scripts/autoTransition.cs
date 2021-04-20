using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class autoTransition : MonoBehaviour {
	
	//SETUP
	
	//References
	public AudioSource source;
	
	//Variables
	private float time;
	public float loopLength;
	private string current;
	private string next;
	
	

	//INITIALISATION
	
	void Start () {
		
		//Setup
		source = this.GetComponent<AudioSource> ();
		loopLength = source.clip.length;
		
		Scene scene = SceneManager.GetActiveScene();
		current = scene.name;
		
		if (current == "1 - CreditCard") {
			
			next = "2 - Demo";
			
		}
		
		else if (current == "3 - TitleCard") {
			
			next = "4 - Main";
			
		}
		
		else {
			
			next = "5 - Ending";
			
		}
		
		//Get sound length
		time = loopLength;
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		//Reduce time
		if (time > 0) {
			
			time -= Time.deltaTime;
			
		}
		
		//Advance scene
		if (time <= 0) {
			
			SceneManager.LoadScene(next);
			
		}
		
	}
	
}