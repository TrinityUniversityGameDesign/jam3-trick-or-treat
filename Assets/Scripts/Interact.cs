using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour {
	static public int items;
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
		if (candy.gameObject.name == "lollipop" || candy.gameObject.name == "chocolate" ||candy.gameObject.name == "candy corn" ||candy.gameObject.name == "candy") {
			items++;
			Debug.Log (items);
			Destroy (candy.gameObject);
		} else if (candy.gameObject.name == "enemy") {
			items--;
		}
			
	}
	void OnTriggerExit2D(Collider2D candy){
		
	}
}
