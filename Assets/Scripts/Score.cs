using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text scoreText;
	public int score = 0;

	// Use this for initialization
	void Start () {
        //scoreText = GetComponent<Text>() as Text;
        //score = Interact.items;

        scoreText = this.gameObject.GetComponent<Text>();
   
	}
	
	// Update is called once per frame
	void Update () {
        //score = Interact.items;
        
		scoreText.text = score.ToString ();
	}
}
