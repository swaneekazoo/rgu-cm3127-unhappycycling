using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoKeyRight : MonoBehaviour {
	
	//SETUP
	
	//References
	public directorDemo director;
	Animator animate;
	
	

	//INITIALISATION
	
	void Start () {
		
		animate = this.GetComponent<Animator>();
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		if (director.stage == 4) {
			
			animate.SetBool ("next", true);
			
		}
		
		else {
			
			animate.SetBool ("next", false);
			
		}
		
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			
			animate.SetBool ("down", true);
			
		}
		
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			
			animate.SetBool ("down", false);
			
		}
		
	}
	
}