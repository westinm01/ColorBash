using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareTrigger : MonoBehaviour
{
    public SpriteRenderer square;

	void Start()
	{
		square = gameObject.GetComponentInParent<SpriteRenderer>();
	}
    protected virtual void takeDamage(){
		Destroy(this.gameObject);
	}

	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player"){
            Debug.Log("Collided with Player");
			if ( square.color != collision.gameObject.GetComponent<SpriteRenderer>().color )
			{
				Debug.Log("Game Over");
			}
			else
			{
				takeDamage();
				ScoreScript.scoreValue += 1; 
			}
		}
	}
}
