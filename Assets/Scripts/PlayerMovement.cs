﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerMovement : MonoBehaviour {

	Vector3 pos;                             
	float speed = 5.0f;   
	float inputX;
	float inputY;


	bool facingRight = true;

	private Rigidbody2D theRigidBody;
    //private bool notHittingObst = true;

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
        /*
        if (notHittingObst)
        {
        */
            if (Mathf.Abs(inputX) > 0)
            {
                theRigidBody.velocity = new Vector3(inputX * speed, 0f, 0f);

                //pos += Vector3.right * inputX * Time.deltaTime * speed;
            }
            else
            {
                //pos += Vector3.up * inputY * Time.deltaTime * speed;
                theRigidBody.velocity = new Vector3(0f, inputY * speed, 0f);
            }
        //}


		//transform.position = pos;   // Move there
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Grass") {
			speed = 2.0f; 
		}
		if (col.tag == "Pavement") {
			speed = 5.0f; 
		}
		if (col.tag == "House") {
			PlayerPrefs.SetInt ("Score", GameObject.Find("score").GetComponent<Score>().score);
			SceneManager.LoadScene ("EndScene"); 
		}
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        notHittingObst = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Stopped colliding with: " + collision.gameObject.name);
        notHittingObst = true;
    }
    */

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        //notHittingObst = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Stopped colliding with: " + collision.gameObject.name);
        //notHittingObst = true;
    }
    
}