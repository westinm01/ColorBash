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

    void Start(){
        spawnTimer = 0;
    }

	void Update(){
		if (spawnTimer > timeBetweenSpawns){
            Instantiate(sq, gameObject.transform.position, Quaternion.identity);
            sq.GetComponent<SquareMover>().squareSpeed = startSpeed;
            spawnTimer = 0;
		}
        else{
            spawnTimer += Time.deltaTime;
        }
	}
}
