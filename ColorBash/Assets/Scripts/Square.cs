using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
	[HideInInspector] public SpriteRenderer square;
    [HideInInspector] public bool isTouching;

    protected SpriteRenderer circleSprite;

	void Start()
	{
		square = gameObject.GetComponent<SpriteRenderer>();
        circleSprite = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<SpriteRenderer>();
        isTouching = false;
	}
    protected virtual void takeDamage(){
		Destroy(this.gameObject);
	}

	protected virtual void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player"){
            // Debug.Log("Collided with Player");
            if (square.color != circleSprite.color)
			{
                isTouching = true;
			}
			else{
				takeDamage();
				ScoreScript.scoreValue += 1; 
			}
		}
	}

    protected virtual void Update(){
        if (isTouching){
            // Debug.Log("IsTouching");
            if (square.color == circleSprite.color ){
                takeDamage();
            }
        }
    }
}
