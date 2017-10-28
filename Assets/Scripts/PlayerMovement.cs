using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Vector3 pos;                             
	float speed = 5.0f;   
	float inputX;
	float inputY;

	bool facingRight = true;

	private Rigidbody2D theRigidBody;


	void Start () {
		//pos = transform.position; 
		theRigidBody = GetComponent<Rigidbody2D> ();


	}

	void Update () {
		inputX = Input.GetAxis ("Horizontal");
		inputY = Input.GetAxis ("Vertical");

		if (inputX > 0 && !facingRight) {
			Flip ();
		}  else if (inputX < 0 && facingRight) {
			Flip ();
		}

		if (Mathf.Abs (inputX) > 0) {
			theRigidBody.velocity = new Vector3(inputX*speed,0f, 0f);
			//pos += Vector3.right * inputX * Time.deltaTime * speed;
		} else {
			//pos += Vector3.up * inputY * Time.deltaTime * speed;
			theRigidBody.velocity = new Vector3(0f,inputY*speed, 0f);
		}


		//transform.position = pos;   // Move there
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}

}