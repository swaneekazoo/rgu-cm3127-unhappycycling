using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTotalUpdate : MonoBehaviour {
	
	//SETUP
	
	//References
	public scoreKeeper score;
	private string totalString;
	private Text totalUI;
	
	//Variables
	
	

	//INITIALISATION
	void Start () {
		
		totalUI = this.GetComponent<Text>();
		
	}
	
	
	
	//LOOP
	void FixedUpdate () {
		
		totalString = score.total.ToString();
		totalUI.text = totalString;
		
	}
	
}