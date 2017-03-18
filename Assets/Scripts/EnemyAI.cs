using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public float moveSpeed;

	public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter2D(Collider2D other) {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "block" || col.gameObject.tag == "Enemy"){
			this.moveSpeed *= -1;
		}

		if (this.moveSpeed > 0) {
			this.spriteRenderer.flipX = false;
		} else if (this.moveSpeed < 0) {
			this.spriteRenderer.flipX = true;
		} else {
		}
		
	}
}
