using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class directorDemo : MonoBehaviour {
	
	//SETUP
	
	//References
	public musicManager music;
	public demoKeyW demoW;
	public demoKeyD demoD;
	public demoKeyS demoS;
	public demoKeyA demoA;
	public demoKeyLeft demoLeft;
	public demoKeyRight demoRight;
	public demoKeySpace demoSpace;
	
	//Variables
	public int stage;
	
	
	
	//METHODS
	
	public void StageUp () {
		
		if (stage == 1) {
			
			demoW.gameObject.SetActive(false);
			demoD.gameObject.SetActive(false);
			demoS.gameObject.SetActive(false);
			demoA.gameObject.SetActive(false);
			demoSpace.gameObject.SetActive(true);
			
		}
		
		if (stage == 2) {
			
			demoSpace.gameObject.SetActive(false);
			demoLeft.gameObject.SetActive(true);
			
		}
		
		if (stage == 3) {
			
			demoLeft.gameObject.SetActive(false);
			demoRight.gameObject.SetActive(true);
			
		}
		
		if (stage == 4) {
			
			demoRight.gameObject.SetActive(false);
			music.SetTransitionTime();
			
		}
		
		stage++;
		
	}
	
	

	//INITIALISATION
	
	void Start () {
		
		stage = 1;
		demoSpace.gameObject.SetActive(false);
		demoLeft.gameObject.SetActive(false);
		demoRight.gameObject.SetActive(false);
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		//Wait for transition
		if (music.timeToTransition <= 0) {
			
			SceneManager.LoadScene("3 - TitleCard");
			
		}
		
	}
	
}