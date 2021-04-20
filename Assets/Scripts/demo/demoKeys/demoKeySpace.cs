using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoKeySpace : MonoBehaviour {
	
	//SETUP
	
	//References
	Animator animate;
	
	

	//INITIALISATION
	
	void Start () {
		
		animate = this.GetComponent<Animator>();
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			
			animate.SetBool ("down", true);
			
		}
		
	}
	
}