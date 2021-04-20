using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rearWheel : MonoBehaviour {
	
	//SETUP
	
	//Libraries
	private WheelJoint2D wheel;
	public Rigidbody2D phys;
	private JointMotor2D motor;
	
	//References to other objects
	public sceneMonitor scene;
	public frontWheel fWheel;
	public bikeScript bike;
	public scoreKeeper score;
	
	public GameObject cogS;
	public GameObject cogM;
	public GameObject cogL;
	
	//Variables
	public float gear;
	public bool ground;
	
	//INITIALISATION
	
	void Start () {
		
		phys = this.GetComponent<Rigidbody2D>();
		wheel = this.GetComponent<WheelJoint2D>();
		motor = wheel.motor;
		gear = 200;
		
	}
	
	
	
	//METHODS
	
	public void BrakeOn () {
		
		if (bike.air == false) {
			
			bike.speed = 0;
			wheel.useMotor = true;
			wheel.motor = motor;
			
			if (bike.phys.velocity.magnitude > 10) {
				
				Instantiate(cogS, phys.position, Quaternion.identity);
				Instantiate(cogM, phys.position, Quaternion.identity);
				Instantiate(cogL, phys.position, Quaternion.identity);
				
			}
			
		}
		
	}
	
	public void BrakeOff () {
		
		wheel.useMotor = false;
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
	}
	
	
	
	//PHYSICS LOOP
	
	void FixedUpdate () {
		
		//Motor
		if (bike.ground == false && bike.air == false&& phys.angularVelocity > -2000) {
		
			phys.AddTorque(-1 * (bike.speed * gear));
			
		}
		
	}
	
	
	
	//COLLISIONS
	
	//On
	private void OnCollisionEnter2D (Collision2D collideOn) {
		
		ground = true;
		
		//End airtime
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
		
		//End wheelie
		if (bike.wheelie == true && bike.wheelieTimer <= 0) {
			
			score.BankTrick ();
			
		}
		
		bike.wheelie = false;
		bike.ResetWheelieTimer ();
		
		//Activate air sensor
		if (fWheel.ground == false && bike.ground == false && collider.tag != "Blah") {
			
			bike.air = true;
			bike.GetTakeoffAngle ();
			
		}
		
    }
}