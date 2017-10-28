using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour {
	private float numFlashes = 5f;//Random.Range(2f,4f);
	private SpriteRenderer sp;
	
	// Use this for initialization
	void Start () {
		sp = GetComponent<SpriteRenderer> ();
		StartCoroutine (Timer());
	}
	
	// Update is called once per frame
	IEnumerator Flash(){
		for (int i = 0; i < numFlashes; i++) {
			sp.enabled = true;
			yield return new WaitForSeconds (Random.value);
			sp.enabled = false;
			yield return new WaitForSeconds (Random.value);
		}
		sp.enabled = false;
	}
	IEnumerator Timer() {
		while (true) {
			yield return new WaitForSeconds (5f);
			StartCoroutine (Flash());
		}
	}
}
