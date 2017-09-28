using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Application.LoadLevel(name);
	}

	public void QuitRequest(string name) {
		Debug.Log("Quit requested:" + name);
		Application.Quit();
	}
}
