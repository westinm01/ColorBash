using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLineScript : MonoBehaviour
{
    [HideInInspector] public GameManager gm;

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player"){
            gm.GameOver();
		}
	}

    void Start(){
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
}
