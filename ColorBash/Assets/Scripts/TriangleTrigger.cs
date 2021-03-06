using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleTrigger : SquareTrigger
{
    protected override void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Player"){
            Debug.Log("Trigger with Player");
            if (collision.gameObject.GetComponent<SpriteRenderer>().color != square.color){
                ScoreScript.scoreValue += 10;
                SaveData.LoadInfo();
                Info.points += 10;

                if (ScoreScript.scoreValue > Info.highScore)
                {
                    gm.newHighScore = true;
                    Info.highScore = ScoreScript.scoreValue;
                }
                SaveData.SaveInfo();
                takeDamage();
            }
            else{
                // Debug.Log("Game over");
            }
		}
	}
}
