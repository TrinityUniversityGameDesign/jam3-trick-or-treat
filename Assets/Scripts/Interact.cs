using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour {
	static private int items;
	public BoxCollider2D candy;
	// Use this for initialization
	void Start () {
		items = 0;
	}

	// Update is called once per frame
//	void Update () {
//
//	}

	void OnTriggerEnter2D(Collider2D candy){
		if (candy.gameObject.name == "lollipop") {
			items = items + 1;
			Destroy (candy.gameObject);
			Debug.Log ("!!!!!!!!!!!");
		} else if (candy.gameObject.name == "enemy") {
			items--;
			Debug.Log (candy);
		}
			
	}
}
