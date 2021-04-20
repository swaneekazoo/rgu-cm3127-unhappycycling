using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManagerDemo : MonoBehaviour {
	
	//SETUP
	
	//Input
	public string w;
    public string d;
    public string s;
	public string a;
	
	//References to other objects
	public directorDemo director;
	public rearWheelDemo rWheel;
	public bikeScriptDemo bike;
	
		//Demo keys
		public demoKeyW demoW;
		public demoKeyD demoD;
		public demoKeyS demoS;
		public demoKeyA demoA;
		
	//Variables
	public string nextKey;
	private float initialAngle;
	
	
	//METHODS
	
	
	
	//INITIALISATION
	
	void Start () {
		
		nextKey = w;
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		//Rear wheel
		
			//Cycle
			
			if (director.stage == 1) {
			
				if (Input.GetKeyDown(w)) {
					
					if (nextKey == w) {
						
						bike.Cycle ();
						
					}

					demoW.On ();
					nextKey = d;
					
				}

				if (Input.GetKeyDown(d)) {
					
					if (nextKey == d) {

						bike.Cycle ();
						
					}
					
					demoD.On ();
					nextKey = s;
					
				}
				
				if (Input.GetKeyDown(s)) {
					
					if (nextKey == s) {

						bike.Cycle ();
						
					}
						
					demoS.On ();
					nextKey = a;
					
				}
				
				if (Input.GetKeyDown(a)) {
					
					if (nextKey == a) {
						
						bike.Cycle ();
						
					}
						
					demoA.On ();
					nextKey = w;
					
				}
				
			}
			
			//Brake
			
			if (director.stage == 2) {
			
				if (Input.GetKeyDown(KeyCode.Space)) {
					
					rWheel.BrakeOn ();
					
				}
				
				if (Input.GetKeyUp(KeyCode.Space)) {
					
					rWheel.BrakeOff ();
					director.StageUp ();
					
				}
				
			}
		
		//Bike script
		
			//Balance
			
			if (director.stage == 3) {
		
				if (Input.GetKey(KeyCode.LeftArrow)) {
					
					bike.BalanceL ();
					
				}
				
				if (Input.GetKeyUp(KeyCode.LeftArrow)) {
					
					bike.BalanceReset ();
					director.StageUp ();
					
				}
				
			}
				
			if (director.stage == 4) {
				
				if (Input.GetKey(KeyCode.RightArrow)) {
					
					bike.BalanceR ();
					
				}
				
				if (Input.GetKeyUp(KeyCode.RightArrow)) {
					
					bike.BalanceReset ();						
					director.StageUp ();
					
				}
				
			}
			
		//Demo key up animations
		
		if (director.stage == 1) {
				
			if (Input.GetKeyUp(w)) {
				
				demoW.Off ();
				
			}
			
			if (Input.GetKeyUp(d)) {
				
				demoD.Off ();
				
			}
			
			if (Input.GetKeyUp(s)) {
				
				demoS.Off ();
				
			}
			
			if (Input.GetKeyUp(a)) {
				
				demoA.Off ();
				
			}
			
		}
		
	}
	
}