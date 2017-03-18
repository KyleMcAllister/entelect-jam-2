using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishAI : MonoBehaviour {

	private int maxMovedDistance = 100;
	private int moveDistance = 0;
	private float moveSpeed = 2.5f;

	private int numberOfTurnsPassed = 0;

	public int numberOfTurnsBeforeMove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (numberOfTurnsPassed >= numberOfTurnsBeforeMove) {
			moveDistance++;
			if (moveDistance >= maxMovedDistance) {
				moveDistance = 0;
				moveSpeed *= -1;
			}
			transform.Translate (new Vector3 (moveSpeed, 0, 0) * Time.deltaTime);
		} 
		else {
			numberOfTurnsPassed++;
		}

	}
}
