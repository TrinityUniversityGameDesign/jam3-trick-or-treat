using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFinalScore : MonoBehaviour {

	//private Score scoreScript;

	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("Score");
		GameObject.Find("score").GetComponent<Score>().score = PlayerPrefs.GetInt ("Score");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
