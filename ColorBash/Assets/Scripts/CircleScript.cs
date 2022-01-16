 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public SpriteRenderer sp;
    public GameManager gm;
    public float rotationSpeed;
    public float rotationSpeedIncrease;
    public float rotationSpeedFrequency;
    public int flipScore;
    public float minY;
    public float maxY;
    public Vector2 knockbackDistance;
    private float rotationTimer;
    public Sprite[] circles;
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rotationTimer = 0;
        SaveData.LoadInfo();

        Debug.Log(Info.circle);
        sp.sprite = circles[Info.circle];
        
    }

    void flip(){
        gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
        rotationSpeed *= -1;
    }

    public void setColorRed(){
        Debug.Log("Setting color to red");
        sp.color = Color.red;
    }

    public void setColorBlue(){
        Debug.Log("Setting color to blue");
        sp.color = Color.blue;
    }

    public void setColorGreen(){
        Debug.Log("Setting color to green");
        sp.color = Color.green;
    }

    public void setColorYellow(){
        Debug.Log("Setting color to yellow");
        sp.color = Color.yellow;
    }

    public void setColorMagenta(){
        Debug.Log("Setting color to magenta");
        sp.color = Color.magenta;
    }

    public void setColorWhite(){
        Debug.Log("Setting color to white");
        sp.color = Color.white;
    }

    void Update(){
        gameObject.transform.RotateAround(gameObject.transform.position, new Vector3(0, 0, 1), -rotationSpeed);
        if (Input.GetKeyDown("space") && ScoreScript.scoreValue >= flipScore && (gameObject.transform.position.y <= minY || gameObject.transform.position.y >= maxY)){
            flip();
        }
        if (gm.hasStarted){
            if (rotationTimer > rotationSpeedFrequency){
                rotationSpeed += rotationSpeedIncrease;
                rotationTimer = 0;
            }
            else{
                rotationTimer += Time.deltaTime;
            }
        }
        // gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2(0.0001f, 0);
        // gameObject.transform.position += new Vector3(0.1f, 0);
    }

}
