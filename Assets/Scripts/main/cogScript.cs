using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cogScript : MonoBehaviour {
	
	public Rigidbody2D phys;

	// Use this for initialization
	void Start () {
		
		phys = this.GetComponent<Rigidbody2D>();
		
		transform.rotation = Random.rotation;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		phys.AddForce(Vector3.up * 50);
		phys.AddForce(transform.up * 10);
		
	}
}
