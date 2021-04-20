using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTrickUpdate : MonoBehaviour {
	
	//SETUP
	
	//References
	public scoreKeeper score;
	private string trickString;
	private Text trickUI;
	
	//Variables
	
	

	//INITIALISATION
	void Start () {
		
		trickUI = this.GetComponent<Text>();
		
	}
	
	
	
	//LOOP
	void FixedUpdate () {
		
		if (score.trick == 0) {
			
			trickUI.text = "";
			
		}
		
		else {
			
			trickString = score.trick.ToString();
			trickUI.text = trickString;
		
		}
		
		trickUI.fontSize = 20 + (score.trick);
		
		if (trickUI.fontSize > 200) {
			
			trickUI.fontSize = 200;
			
		}
		
	}
}
