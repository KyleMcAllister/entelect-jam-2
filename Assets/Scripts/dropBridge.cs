using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropBridge : MonoBehaviour {


	public GameObject bridge;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Destroy (bridge);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
