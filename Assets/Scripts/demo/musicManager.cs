using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicManager : MonoBehaviour {
	
	//SETUP
	
	//References
	public directorDemo director;
	public AudioSource hats;
	public musicDrums mDrums;
	public AudioSource drums;
	public rearWheelDemo rWheel;
	
	//Variables
	private float time;
	public float loopLength;
	public float timeToTransition;
	
	

	//INITIALISATION
	
	void Start () {
		
		//Setup
		hats = this.GetComponent<AudioSource> ();
		loopLength = hats.clip.length;
		drums = mDrums.GetComponent<AudioSource> ();
		timeToTransition = 10;
		
	}
	
	
	
	//METHODS
	
	public void SetTransitionTime () {
		
		timeToTransition = loopLength - hats.time;
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		if (director.stage == 1) {
			
			hats.volume = 1 - (-1 * rWheel.phys.angularVelocity / 2000);
			
		}
		
		else {
			
			hats.volume = 0;
			
		}
		
		if (timeToTransition < 10) {
			
			timeToTransition -= Time.deltaTime;
			
		}
		
	}
	
}