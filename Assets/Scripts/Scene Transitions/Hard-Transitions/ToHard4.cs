﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHard4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			SceneManager.LoadScene ("Scenes/Hard-Mode/Level4-1");
		}
	}
}
