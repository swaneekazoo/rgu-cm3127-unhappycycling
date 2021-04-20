using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trickLabelUpdate : MonoBehaviour {
	
	//SETUP
	
	//References
	public scoreKeeper score;
	private Text trickLabel;
	
	//Variables
	
	

	//INITIALISATION
	void Start () {
		
		trickLabel = this.GetComponent<Text>();
		
	}
	
	
	
	//LOOP
	void FixedUpdate () {
		
		trickLabel.text = score.trickType;
		
	}
}
