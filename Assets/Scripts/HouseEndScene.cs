﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseEndScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			PlayerPrefs.SetInt ("Score", GameObject.Find("score").GetComponent<Score>().score);
			SceneManager.LoadScene ("EndScene"); 
		}
	}

}
