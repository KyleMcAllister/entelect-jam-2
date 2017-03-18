using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBoss : MonoBehaviour {

	public GameObject boss;
	public GameObject winImage;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag=="bossKiller"){
			Destroy (this.boss);
			this.winImage.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
