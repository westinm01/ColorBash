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

    Color getRandomColor(){
        int randColor = Random.Range(0, 3);
        Color returnColor = Color.white;
        Debug.Log(randColor);
        switch (randColor){
            case 0:
                returnColor = Color.red;
                break;
            case 1:
                returnColor = Color.blue;
                break;
            case 2:
                returnColor = Color.green;
                break;
            default:
                Debug.Log("Color out of range");
                break;
        }
        return returnColor;
    }

	void Update(){
		if (spawnTimer > timeBetweenSpawns){
            Instantiate(sq, gameObject.transform.position, Quaternion.identity);
            sq.GetComponent<SquareMover>().squareSpeed = startSpeed;
            sq.GetComponent<SpriteRenderer>().color = getRandomColor();
            spawnTimer = 0;
		}
        else{
            spawnTimer += Time.deltaTime;
        }
	}
}
