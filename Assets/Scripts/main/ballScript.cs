using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {
	
	//SETUP
	
	//Libraries
	public Rigidbody2D phys;

	//INITIALISATION
	void Start () {
		
		//Setup
		phys = this.GetComponent<Rigidbody2D>();
		
	}
	
	//LOOP
	void Update () {
		
	}
	
	private void OnCollisionEnter2D(Collision2D collideOn)	{
		
		GameObject collider = collideOn.gameObject;

		if (collider.tag == "Player") {
			
			phys.AddForce(Vector3.up * 1000);
			phys.AddForce(Vector3.right * 1000);
			
		}
		
	}
	
}