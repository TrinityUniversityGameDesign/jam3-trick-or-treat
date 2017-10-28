﻿using System.Collections;
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
        currMov = 0;
        theRigidbody2D.AddForce(Vector2.right * speed);
    }
	
	// Update is called once per frame
	void Update () {
        //theRigidbody2D.velocity = new Vector2(Time.deltaTime * speed, 0);
        //transform.position = transform.position + speed * transform.forward;

        //transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        //Debug.Log(transform.position);

        

        if (hitBush)
        {
            //Debug.Log("Hit bush!!!");
            
            int nextMove = (int)Random.Range(0, 4);

            Debug.Log("Next random move is : " + nextMove);
            Debug.Log("Curr move is        : " + currMov);
            if (nextMove == currMov)
            {
                
                nextMove = (nextMove++) % 4;
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
}
