using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public GameObject loseImage;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag.Equals("Player")){
			Destroy(other.gameObject);
			loseImage.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
