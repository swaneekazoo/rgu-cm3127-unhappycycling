using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontWheel : MonoBehaviour {
	
	//SETUP
	
	//References to other objects
	public rearWheel rWheel;
	public bikeScript bike;
	public scoreKeeper score;
	
	//Variables
	public bool ground;
	
	

	//INITIALISATION
	
	void Start () {
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
	}
	
	
	
	//COLLISIONS
	
	//On
	private void OnCollisionEnter2D (Collision2D collideOn) {
		
		ground = true;
		
		//End tricks
		
		//Wheelie
		if (bike.wheelie == true && bike.wheelieTimer <= 0) {
			
			score.BankTrick ();
			
		}
		
		bike.wheelie = false;
		bike.ResetWheelieTimer ();
		
		//Airtime
		if (bike.air == true && bike.airTimer <= 0) {
			
			score.BankTrick ();
			
		}
		
		bike.air = false;
		bike.ResetAirTimer ();
		
    }
	
	//Off
	private void OnCollisionExit2D (Collision2D collideOff) {
		
		GameObject collider = collideOff.gameObject;
		
		ground = false;
		
		//Activate wheelie sensor
		if (rWheel.ground == true && bike.ground == false && collider.tag != "Blah") {
			
			bike.wheelie = true;
			
		}
		
		//Activate air sensor
		if (rWheel.ground == false && bike.ground == false && collider.tag != "Blah") {
			
			bike.air = true;
			bike.GetTakeoffAngle ();
			
		}
		
    }
	
}