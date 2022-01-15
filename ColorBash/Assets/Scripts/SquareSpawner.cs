using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
	public Square sq;
    public Triangle tri;
	public float startSpeed;
	public float speedIncrease;
    public float speedIncreaseFrequency;
	public float timeBetweenSpawns;
    private int numIncreases;
	private float spawnTimer;
    private float speedTimer;

    void Start(){
        spawnTimer = 0;
        speedTimer = 0;
        numIncreases = 0;
    }

    Color getRandomColor(){
        int randColor = Random.Range(0, 3);
        Color returnColor = Color.white;
        // Debug.Log(randColor);
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

    void spawnNewShape(){
        int randShape = Random.Range(0, 2);
        // Debug.Log(randShape);
        switch (randShape){
            case 0:
                Square newSquare = Instantiate(sq, gameObject.transform.position, Quaternion.identity);
                newSquare.GetComponent<SquareMover>().squareSpeed = startSpeed + (speedIncrease * numIncreases);
                newSquare.GetComponent<SpriteRenderer>().color = getRandomColor();
                break;
            case 1:
                Triangle newTri = Instantiate(tri, gameObject.transform.position, Quaternion.identity);
                newTri.GetComponent<SquareMover>().squareSpeed = startSpeed + (speedIncrease * numIncreases);
                newTri.GetComponent<SpriteRenderer>().color = getRandomColor();
                break;
        }

    }

	void Update(){
		if (spawnTimer > timeBetweenSpawns){
            spawnNewShape();
            spawnTimer = 0;
		}
        else{
            spawnTimer += Time.deltaTime;
        }

        if (speedTimer > speedIncreaseFrequency){
            numIncreases++;
            speedTimer = 0;
        }
        else{
            speedTimer += Time.deltaTime;
        }
	}
}
