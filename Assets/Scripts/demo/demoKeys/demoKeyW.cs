﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoKeyW : MonoBehaviour {
	
	//SETUP
	
	//References
	Animator animate;
	public inputManagerDemo input;
	
	

	//INITIALISATION
	
	void Start () {
		
		animate = this.GetComponent<Animator>();
		
	}
	
	
	
	//METHODS
	
	//Key down
		public void On () {
			
			animate.SetBool ("down", true);
			
		}
		
	//Key up
		public void Off () {
			
			animate.SetBool ("down", false);
			
		}
		
		
	
	//LOOP
	
	void Update () {
		
		if (input.nextKey == "w") {
			
			animate.SetBool ("next", true);
			
		}
		
		else {
			
			animate.SetBool ("next", false);
			
		}
		
	}
	
}