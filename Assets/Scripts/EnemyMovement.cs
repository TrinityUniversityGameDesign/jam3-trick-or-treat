using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed = 5f;
    private Rigidbody2D theRigidbody2D;
    private bool hitBush = false;

	// Use this for initialization
	void Start () {
        theRigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //theRigidbody2D.velocity = new Vector2(Time.deltaTime * speed, 0);
        //transform.position = transform.position + speed * transform.forward;
        
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        Debug.Log(transform.position);

       if (hitBush)
        {
            Debug.Log("HitBush"); 
        }

    }

    private void MoveDirection(float speed)
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitBush = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        hitBush = false;
    }

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Grass") {
			speed = 2.0f; 
		}
		if (col.tag == "Pavement") {
			speed = 5.0f; 
		}
	}
}
