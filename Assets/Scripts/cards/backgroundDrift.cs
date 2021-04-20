using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundDrift : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.up / 100);
		transform.Translate(Vector3.right / 50);
		transform.Rotate(new Vector3 (0.3f, 0.2f, 0.3f));
		transform.localScale += new Vector3(0.005f, 0.005f, 0.005f); 

		
	}
}
