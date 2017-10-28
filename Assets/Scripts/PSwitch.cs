using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSwitch : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)) {
			anim.SetInteger("type", 0);
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			anim.SetInteger("type",1);
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)) {
			anim.SetInteger ("type", 2);
		}
		if(Input.GetKeyDown(KeyCode.Alpha4)) {
			anim.SetInteger ("type", 3);
		}
	}
}
