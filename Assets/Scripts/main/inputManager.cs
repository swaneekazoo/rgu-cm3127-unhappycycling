using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour {
	
	//SETUP
	
	//Input
	public string w;
    public string d;
    public string s;
	public string a;
	
	//References to other objects
	public rearWheel rWheel;
	public bikeScript bike;
	
		//Demo keys
		public demoKeyW demoW;
		public demoKeyD demoD;
		public demoKeyS demoS;
		public demoKeyA demoA;
	
	//Variables
	public string nextKey;
	
	
	//METHODS
	
	
	
	//INITIALISATION
	
	void Start () {
		
		nextKey = w;
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		//Rear wheel
		
			//Cycle
			if (Input.GetKeyDown(w)) {
				
				if (nextKey == w) {
					
					bike.Cycle();
						
				}
				
				nextKey = d;
				
			}

			if (Input.GetKeyDown(d)) {
				
				if (nextKey == d) {

					bike.Cycle();
					
				}
				
				nextKey = s;
				
			}
			
			if (Input.GetKeyDown(s)) {
				
				if (nextKey == s) {

					bike.Cycle();
					
				}
					
				nextKey = a;
				
			}
			
			if (Input.GetKeyDown(a)) {
				
				if (nextKey == a) {
					
					bike.Cycle();
					
				}
				
				nextKey = w;
				
			}
			
			//Brake
			if (Input.GetKeyDown(KeyCode.Space)) {
				
				rWheel.BrakeOn();
				
			}
			
			if (Input.GetKeyUp(KeyCode.Space)) {
				
				rWheel.BrakeOff();
				
			}
		
		//Bike script
		
			//Balance
			if (Input.GetKey(KeyCode.LeftArrow)) {
				
				bike.BalanceL();
				
			}
			
			if (Input.GetKey(KeyCode.RightArrow)) {
				
				bike.BalanceR();
				
			}
			
			if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
				
				bike.BalanceReset();
				
			}
		
	}
	
}