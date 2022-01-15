using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
	public Square sq;

	public float startSpeed;
	public float speedIncrease;
	public float timeBetweenSpawns;
	private float spawnTimer;

	void Update(){
		if (spawnTimer >= timeBetweenSpawns){
            Instantiate(sq, gameObject.transform.position, Quaternion.identity);
            sq.rb.velocity = new Vector2(-startSpeed, 0);
		}
        else{
            spawnTimer += Time.deltaTime;
        }
	}
}
