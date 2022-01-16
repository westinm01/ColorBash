using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SquareSpawner : MonoBehaviour
{
	public Square sq;
    public Triangle tri;
    public GameManager gm;
	public float startSpeed;
	public float speedIncrease;
    public float speedIncreaseFrequency;
	public int timeBetweenSpawns;
    public float spawnIncreaseRate;
    public float spawnIncreaseFrequency;
    public float maxSpawnIncrease;
    private int numIncreases;
	private float spawnTimer;
    private float speedTimer;

    private float baseSpawnTimer;
    private float spawnIncreaseTimer;


    void Start(){
        spawnTimer = 0;
        speedTimer = 0;
        numIncreases = 0;
        baseSpawnTimer = 0.1f;
        spawnIncreaseTimer = 0;
    }

    Color getRandomColor(){
        if ( ScoreScript.scoreValue < 150 ){
            ColorBoard.changeColorBoard();
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
        else if (ScoreScript.scoreValue < 300 ){
            ColorBoard.changeColorBoard();
            int randColor = Random.Range(0, 4);
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
                case 3:
                    returnColor = Color.yellow;
                    break;
                case 4:
                    returnColor = Color.magenta;
                    break;
                default:
                    Debug.Log("Color out of range");
                    break;
            }
            return returnColor;
        }
        else if (ScoreScript.scoreValue < 450 ){
            ColorBoard.changeColorBoard();
            int randColor = Random.Range(0, 5);
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
                case 3:
                    returnColor = Color.yellow;
                    break;
                case 4:
                    returnColor = Color.magenta;
                    break;
                case 5:
                    returnColor = Color.white;
                    break;
                default:
                    Debug.Log("Color out of range");
                    break;
            }
            return returnColor;
        }
        else{
            ColorBoard.changeColorBoard();
            int randColor = Random.Range(0, 6);
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
                case 3:
                    returnColor = Color.yellow;
                    break;
                default:
                    Debug.Log("Color out of range");
                    break;
            }
            return returnColor;
        }
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
        if (!gm.hasStarted){
            return;
        }

        
		if (spawnTimer > timeBetweenSpawns){
            spawnNewShape();
            spawnTimer = Random.Range(baseSpawnTimer, maxSpawnIncrease);
		}
        else{
            spawnTimer += Time.deltaTime;
        }

        if (spawnIncreaseTimer > spawnIncreaseFrequency){
            Debug.Log("Speed up spawn");
            if (baseSpawnTimer < maxSpawnIncrease + spawnIncreaseRate){
                baseSpawnTimer += spawnIncreaseRate;
            }
            spawnIncreaseTimer = 0;
        }
        else{
            spawnIncreaseTimer+= Time.deltaTime;
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
