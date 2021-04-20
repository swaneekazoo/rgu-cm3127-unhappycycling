using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeScript : MonoBehaviour {
	
	//SETUP
	
	//Libraries
	public Rigidbody2D phys;
	
	//References to other objects
	public scoreKeeper score;
	public frontWheel fWheel;
	public rearWheel rWheel;
	
	//Variables
	public float speed;
	public float balance;
	public bool ground;
	public bool air;
	public float airTimer;
	public bool wheelie;
	public float wheelieTimer;
	private float takeoffAngle;
	
	
	
	//INITIALISATION
	
	void Start () {
		
		//Setup
		phys = this.GetComponent<Rigidbody2D>();
		
	}
	
	
	
	//METHODS
	
	//Movement
	
		//Cycle
		public void Cycle () {
			
			if (speed < 10) { 
			
				speed++;
				
			}
			
		}
		
		//Balance
		public void BalanceL () {
			
			if (balance < 10) {
			
				balance++;
				
			}
			
		}
		
		public void BalanceR () {
			
			if (balance > -10) {
			
				balance--;
				
			}
			
		}
		
		public void BalanceReset () {
			
			balance = 0;
			
		}
	
	//Tricks
	
		//Reset air timer
		public void ResetAirTimer () {
			
			airTimer = 0.6f;
			
		}
		
		//Reset wheelie timer
		public void ResetWheelieTimer () {
			
			wheelieTimer = 0.6f;
			
		}
	
		//Get angle on takeoff
		public void GetTakeoffAngle () {
			
			takeoffAngle = phys.rotation;
			
		}
	
	
	
	//LOOP
	
	void FixedUpdate () {
		
		//Detect airtime
		if (air == true && airTimer > 0) {
			
			airTimer -= Time.deltaTime;
			
		}
		
		//Detect wheelie
		if (wheelie == true && wheelieTimer > 0) {
			
			wheelieTimer -= Time.deltaTime;
			
		}
		
		//Movement
		
		//Balance
		if (phys.angularVelocity > -200 && phys.angularVelocity < 200) {
		
			phys.AddTorque (balance * 50);
			
		}
		
		//Flight
		if (air == true) {
			
			phys.AddForce (Vector3.up * speed * 2);
			
		}
		
		//Decay
		if (speed > 0) {
			
			speed -= Time.deltaTime * 6;
			
		}
		
		if (speed < 0) {
			
			speed = 0;
			
		}
		
		
		
		//Tricks
		
		//Wheelie
		
		if (wheelie == true && wheelieTimer <= 0) {
			
			score.Wheelie ();
			
		}
		
		//Air
		
		//Flips
		if (air == true) {
			
			if (phys.rotation <= (takeoffAngle - 360)) {
				
				score.Frontflip ();
				takeoffAngle = takeoffAngle - 360;
				
			}
			
			if (phys.rotation >= (takeoffAngle + 360)) {
				
				score.Backflip ();
				takeoffAngle = takeoffAngle + 360;
				
			}
			
			//Airtime
			
			if (air == true && airTimer <= 0) {
			
				score.Airtime ();
				
			}
			
		}
		
	}
	
	
	
	//COLLISIONS
	
	//On
	private void OnCollisionEnter2D (Collision2D collideOn) {
		
		ground = true;
		score.FailTrick ();
		air = false;
		wheelie = false;
		ResetAirTimer ();
		ResetWheelieTimer ();
		
    }
	
	//Off
	private void OnCollisionExit2D (Collision2D collideOff) {
		
		ground = false;
		
    }
}