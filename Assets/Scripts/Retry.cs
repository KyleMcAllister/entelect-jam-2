using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {
	public void RetryEventHandler(){
		SceneManager.LoadScene (0);
	}

	public void Quit(){
		Application.Quit();
	}
}
