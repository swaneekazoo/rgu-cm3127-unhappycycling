using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeScriptDemo : MonoBehaviour {
	
	//SETUP
	
	//Libraries
	public Rigidbody2D phys;
	
	//References to other objects
	public directorDemo director;
	public rearWheelDemo rWheel;
	
	//Variables
	public float speed;
	public float balance;
	public bool balanceLComplete;
	public bool balanceRComplete;
	
	
	
	//INITIALISATION
	
	void Start () {
		
		//Setup
		phys = this.GetComponent<Rigidbody2D>();
		
	}
	
	
	
	//METHODS
	
	//Movement
	
	//Cycle
	public void Cycle () {
		
		speed++;
		
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
	
	
	
	//LOOP
	
	void FixedUpdate () {
		
		//Movement
		
			//Balance
			if (phys.angularVelocity > -200 && phys.angularVelocity < 200) {
			
				phys.AddTorque (balance * 50);
				
			}
			
			//Decay
			if (speed > 0) {
				
				speed -= Time.deltaTime * 6;
				
			}
			
			if (speed < 0) {
				
				speed = 0;
				
			}
		
	}
		
}