﻿using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class MenuToSecond : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print ("Hello");
			UnityEngine.SceneManagement.SceneManager.LoadScene ("OnePersonRoomScene");
		}
	}
}
