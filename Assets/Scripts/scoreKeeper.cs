using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeper : MonoBehaviour {
	
	//SETUP
	
	//References
	
	//Variables
	public int total = 0;
	public int trick = 0;
	public string trickType;
	
	
	
	//INITIALISATION
	
	void Start () {
		
		//Don't destroy on load
		DontDestroyOnLoad (this.gameObject);
		if (FindObjectsOfType (this.GetType()).Length > 1) {
			
			Destroy (this.gameObject);
			
		}
		
	}
	
	
	
	//METHODS
	
	//Wheelie
	
	public void Wheelie () {
		
		trick++;
		trickType = "wheelie";
		
	}
	
	//Airtime
	public void Airtime () {
		
		trick++;
		
		if (trickType != "frontflip" && trickType != "backflip") {
			
			trickType = "airtime";
			
		}
		
	}
	
	//Frontflip
	public void Frontflip () {
		
		trick += 70;
		trickType = "frontflip";
		
	}
	
	public void Backflip () {
		
		trick += 70;
		trickType = "backflip";
		
	}
	
	//Bank trick score
	public void BankTrick () {
		
		total += trick;
		trick = 0;
		
		//Compensate for airtime/wheelie delay
			
		total += 30;

		
	}
	
	//Fail trick
	public void FailTrick () {
		
		trick = 0;
		
	}
	
	
	
	//LOOP
	
	void FixedUpdate () {
		
		//Clear trickType
		if (trick == 0) {
			
			trickType = "";
			
		}
		
	}
	
}