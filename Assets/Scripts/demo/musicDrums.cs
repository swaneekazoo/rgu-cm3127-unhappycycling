using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicDrums : MonoBehaviour {
	
	//SETUP
	public directorDemo director;
	public AudioSource drums;
	public rearWheelDemo rWheel;

	//INITIALISATION
	
	void Start () {
		
		drums = this.GetComponent<AudioSource> ();
		
	}
	
	
	
	//LOOP
	
	void Update () {
		
		if (director.stage == 1) {
		
			drums.volume = -1 * rWheel.phys.angularVelocity / 2000;
		
		}
		
		else {
			
			drums.volume = 1;
			
		}
		
	}
	
}