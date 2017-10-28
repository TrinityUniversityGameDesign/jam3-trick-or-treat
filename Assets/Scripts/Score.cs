using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text scoreText;
	public static float score;
	// Use this for initialization
	void Start () {
		scoreText=GetComponent<Text>() as Text;
		score = Interact.items;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString ();
	}
}
