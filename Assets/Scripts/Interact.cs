using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour {
	//static public int items;
	public BoxCollider2D candy;

    private Score scoreScript;
    private bool invunerable;
    private SpriteRenderer sp;

	// Use this for initialization
	void Start () {
        //items = 0;
        scoreScript = GameObject.Find("score").GetComponent<Score>();
        sp = GetComponent<SpriteRenderer>();
        invunerable = false;
	}

    private void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D candy){
		if (candy.gameObject.name == "lollipop" || candy.gameObject.name == "chocolate" || candy.gameObject.name == "candy corn" || candy.gameObject.name == "candy") {
            //items++;
            //Debug.Log (items);
            scoreScript.score++;
			Destroy (candy.gameObject);
		}
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Badboys" && !invunerable)
        {
            Debug.Log("ow ow ouchies");
            Debug.Log("dec on " + scoreScript.score);
            scoreScript.score--;
            invunerable = true;
            StartCoroutine(InvunTimeCounter());
        }
    }

    private int nFlashes = 3;

    //co-routine
    IEnumerator InvunTimeCounter()
    {
        for (int i = 0; i < nFlashes; i++)
        {
            sp.enabled = true;
            yield return new WaitForSeconds(.2f);
            sp.enabled = false;
            yield return new WaitForSeconds(.2f);

        }
        sp.enabled = true;
        /*
        yield return new WaitForSeconds(3);
        invunerable = false;
        */
    }
}
