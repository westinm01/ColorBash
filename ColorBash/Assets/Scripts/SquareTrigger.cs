using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareTrigger : MonoBehaviour
{
    public SpriteRenderer square;
	public ParticleSystem explosion;
	public AudioClip deathClip;
	private GameManager gm;
	void Start()
	{
		square = gameObject.GetComponentInParent<SpriteRenderer>();
	}

	protected virtual void playDeathNoise(){
		// Debug.Log("Playing death noise");
		AudioSource.PlayClipAtPoint(deathClip, gameObject.transform.position);
	}

	protected virtual void spawnExplosion(){
        // Debug.Log("explosion");
        ParticleSystem temp = Instantiate(explosion, transform.position, Quaternion.identity);
        ParticleSystem.MainModule tempmain = temp.main;
        tempmain.startColor = gameObject.GetComponentInParent<SpriteRenderer>().color;
        temp.Play();
        Destroy(temp, 1f);
    }

	protected virtual void takeDamage(){
		// transform.parent.gameObject.SetActive(false);
		playDeathNoise();
		spawnExplosion();
		Destroy(transform.parent.gameObject);
	}
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player"){
            Debug.Log("Trigger with Player");
			if ( square.color != collision.gameObject.GetComponent<SpriteRenderer>().color )
			{
				// Debug.Log("Game Over");
			}
			else
			{
				takeDamage();
				ScoreScript.scoreValue += 10;
				SaveData.LoadInfo();
				Info.points += 10;
				if (ScoreScript.scoreValue > Info.highScore)
				{
					
					Info.highScore = ScoreScript.scoreValue;
				}
				SaveData.SaveInfo();
			}
		}
	}
}
