﻿using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class MenuToThird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {			
			UnityEngine.SceneManagement.SceneManager.LoadScene ("ThreePersonRoomScene");
		}
	}
}
