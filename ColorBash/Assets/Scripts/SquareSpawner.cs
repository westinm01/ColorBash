using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SquareSpawner : MonoBehaviour
{
	public Square sq;
    public Triangle tri;
    public CircleEnemy cri;
    public GameManager gm;

    public int rotation;
    public int maxShapes;
    public bool canSpawn;

    [Header("Speed variables")]
	public float startSpeed;
    public float maxSpeed;
	public float speedIncrease;
    public float speedIncreaseFrequency;
    [Header("Spawn variables")]
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
        if (!canSpawn){
            return;
        }
        int randShape = Random.Range(0, maxShapes * 10);
        // int randShape = 26;
        // Debug.Log(randShape);
        // switch (randShape){
            // case 0:
        if (randShape < 13){
            Square newSquare = Instantiate(sq, gameObject.transform.position, Quaternion.identity);
            newSquare.GetComponent<SquareMover>().squareSpeed = startSpeed + (speedIncrease * numIncreases);
            newSquare.GetComponent<SpriteRenderer>().color = getRandomColor();
            newSquare.gameObject.transform.RotateAround(newSquare.gameObject.transform.position, new Vector3(0, 0, 1), rotation);
        }
        else if (randShape < 27){
            Triangle newTri = Instantiate(tri, gameObject.transform.position, Quaternion.identity);
            newTri.GetComponent<SquareMover>().squareSpeed = startSpeed + (speedIncrease * numIncreases);
            newTri.GetComponent<SpriteRenderer>().color = getRandomColor();
            newTri.gameObject.transform.RotateAround(newTri.gameObject.transform.position, new Vector3(0, 0, 1), rotation);
        }
        else if (randShape < 30){
            Vector3 adjustmentV = Vector3.zero;
            if (rotation == 0){
                adjustmentV = new Vector3(0, 0.75f, 0);
            }
            else if (rotation == 180){
                adjustmentV = new Vector3(0, -0.75f, 0);
            }
            CircleEnemy newCri = Instantiate(cri, gameObject.transform.position + adjustmentV, Quaternion.identity);
            newCri.GetComponent<SquareMover>().squareSpeed = startSpeed + (speedIncrease * numIncreases);
            newCri.gameObject.transform.RotateAround(newCri.gameObject.transform.position, new Vector3(0, 0, 1), rotation);
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
                spawnIncreaseTimer = 0;
            }
            else{
                Debug.Log("Max spawn rate reached");
            }
        }
        else{
            spawnIncreaseTimer+= Time.deltaTime;
        }

        if (speedTimer > speedIncreaseFrequency){
            if (speedIncrease * numIncreases < maxSpeed){
                numIncreases++;
                speedTimer = 0;
            }
            else{
                Debug.Log("Max speed reached");
            }
        }
        else{
            speedTimer += Time.deltaTime;
        }
	}
}
