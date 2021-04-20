using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rearWheelDemo : MonoBehaviour {
	
	//SETUP
	
	//Libraries
	private WheelJoint2D wheel;
	public Rigidbody2D phys;
	private JointMotor2D motor;
	
	//References
	public directorDemo director;
	public bikeScriptDemo bike;
	
	//Variables
	private float gear = 30;

	//INITIALISATION
	
	void Start () {
		
		phys = this.GetComponent<Rigidbody2D>();
		wheel = this.GetComponent<WheelJoint2D>();
		motor = wheel.motor;
		
	}
	
	
	
	//METHODS
	
	public void BrakeOn () {
			
		bike.speed = 0;
		wheel.useMotor = true;
		wheel.motor = motor;
		
	}
	
	public void BrakeOff () {
		
		wheel.useMotor = false;
		
	}
	
	
	
	//PHYSICS LOOP
	
	void FixedUpdate () {
		
		//Motor
		
		if (director.stage == 1) {
			
			if (phys.angularVelocity > -2000) {
			
				phys.AddTorque(-1 * (bike.speed * gear));
				
			}
			
			if (phys.angularVelocity <= -2000) {
				
				director.StageUp();
				
			}
		
		}
		
	}
	
}