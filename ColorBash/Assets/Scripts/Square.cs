using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
	[HideInInspector] public SpriteRenderer square;
    [HideInInspector] public bool isTouching;

    protected SpriteRenderer circleSprite;
	public ParticleSystem explosion;
    public AudioClip deathClip;
    protected GameManager gm;

	void Start()
	{
		square = gameObject.GetComponent<SpriteRenderer>();
        circleSprite = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<SpriteRenderer>();
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        isTouching = false;
	}

    protected virtual void playDeathNoise(){
		// Debug.Log("Playing death noise");
		AudioSource.PlayClipAtPoint(deathClip, gameObject.transform.position);
	}
    
    protected virtual void spawnExplosion(){
        // Debug.Log("explosion");
        ParticleSystem temp = Instantiate(explosion, transform.position, Quaternion.identity);
        ParticleSystem.MainModule tempmain = temp.main;
        tempmain.startColor = gameObject.GetComponent<SpriteRenderer>().color;
        temp.Play();
        Destroy(temp, 1f);
    }
    protected virtual void takeDamage(){
        playDeathNoise();
        spawnExplosion();
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
		}
	}

    protected virtual void Update(){
        if (isTouching){
            // Debug.Log("IsTouching");
            if (square.color == circleSprite.color ){
                SaveData.LoadInfo();
                Info.points += 10;

                if (ScoreScript.scoreValue > Info.highScore)
                {
                    Info.highScore = ScoreScript.scoreValue;
                }
                SaveData.SaveInfo();
                takeDamage();
            }
        }
    }
}
