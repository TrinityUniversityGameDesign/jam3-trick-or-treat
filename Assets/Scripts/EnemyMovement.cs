using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed = 5f;
    private Rigidbody2D theRigidbody2D;
    private int currMov;

	// Use this for initialization
	void Start () {
        theRigidbody2D = GetComponent<Rigidbody2D>();

        // set current movement as 0 (go right)
        Debug.Log("Current move is " + currMov + " moving right");
        currMov = 0;
        theRigidbody2D.AddForce(Vector2.right * speed);
    }
	
	// Update is called once per frame
	void Update () {        

        if (Mathf.Abs(theRigidbody2D.velocity.x) < 0.001 && Mathf.Abs(theRigidbody2D.velocity.y) < 0.001)
        {
            int nextMove = (int)Random.Range(0, 4);

            Debug.Log("Next random move is : " + nextMove);
            Debug.Log("prev move was       : " + currMov);
            if (nextMove == currMov)
            {
                nextMove = (nextMove+1) % 4;
                Debug.Log("Same as previous move, new move is : " + nextMove);
            }
            currMov = nextMove;
            switch (nextMove)
            {
                case 0:
                    Debug.Log("Move right");
                    theRigidbody2D.AddForce(Vector2.right * speed);
                    break;
                case 1:
                    Debug.Log("Move left");
                    theRigidbody2D.AddForce(Vector2.left * speed);
                    break;
                case 2:
                    Debug.Log("Move up");
                    theRigidbody2D.AddForce(Vector2.up * speed);
                    break;
                case 3:
                    Debug.Log("Move down");
                    theRigidbody2D.AddForce(Vector2.down * speed);
                    break;
            }
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
    }
}
