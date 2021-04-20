using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter2D(Collider2D collision)	{
        GameObject obj = collision.gameObject;
		
		if (obj.tag == "Player") {
			
			SceneManager.LoadScene("5 - Ending");
			
		}
			
    }

	
}