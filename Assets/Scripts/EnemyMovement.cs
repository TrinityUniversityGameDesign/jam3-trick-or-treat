using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed = 5f;
    private Rigidbody2D theRigidbody2D;
    private bool hitBush;
    private int currMov;

	// Use this for initialization
	void Start () {
        theRigidbody2D = GetComponent<Rigidbody2D>();
        hitBush = false;

        // set current movement as 0 (go right)
        currMov = 0;
        theRigidbody2D.AddForce(Vector2.right * speed);
    }
	
	// Update is called once per frame
	void Update () {        

        if (hitBush)
        {
            int nextMove = (int)Random.Range(0, 4);

            Debug.Log("Next random move is : " + nextMove);
            Debug.Log("Curr move is        : " + currMov);
            if (nextMove == currMov)
            {
                
                nextMove = (nextMove+1) % 4;
                Debug.Log("Same as previous move, new move is : " + nextMove);
            }
            switch (nextMove)
            {
                case 0:
                    Debug.Log("Move right");
                    theRigidbody2D.AddForce(Vector2.right * speed);
                    hitBush = false;
                    break;
                case 1:
                    Debug.Log("Move left");
                    theRigidbody2D.AddForce(Vector2.left * speed);
                    hitBush = false;
                    break;
                case 2:
                    Debug.Log("Move up");
                    theRigidbody2D.AddForce(Vector2.up * speed);
                    hitBush = false;
                    break;
                case 3:
                    Debug.Log("Move down");
                    theRigidbody2D.AddForce(Vector2.down * speed);
                    hitBush = false;
                    break;
            }
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitBush = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        hitBush = false;
    }
    /*
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Grass") {
            theRigidbody2D.velocity = theRigidbody2D.velocity * 2 / 5f;
			speed = 20.0f; 
		}
		if (col.tag == "Pavement") {
            theRigidbody2D.velocity = theRigidbody2D
			speed = 50.0f; 
		}
	}
    */
}
