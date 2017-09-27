﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("Level load requested:" + name);
	}

	public void QuitRequest(string name) {
		Debug.Log("Quit requested:" + name);
	}
}