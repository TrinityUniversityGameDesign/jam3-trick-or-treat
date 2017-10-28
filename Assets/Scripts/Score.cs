using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text scoreText;
	public  int score;

	// Use this for initialization
	void Start () {
        //scoreText = GetComponent<Text>() as Text;
        //score = Interact.items;

        scoreText = this.gameObject.GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //score = Interact.items;
        
		scoreText.text = score.ToString ();
	}
}
