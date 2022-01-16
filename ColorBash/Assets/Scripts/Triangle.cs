using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Square
{
    protected override void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player"){
            Debug.Log("Collided with Player");
            if (collision.gameObject.GetComponent<SpriteRenderer>().color != this.gameObject.GetComponent<SpriteRenderer>().color){
                ScoreScript.scoreValue += 1; 
                takeDamage();
            }
            else{
                isTouching = true;
            }
		}
	}

    protected override void Update(){
        if (isTouching){
            // Debug.Log("IsTouching");
            if (square.color != circleSprite.color ){
                takeDamage();
            }
        }
    }
}
