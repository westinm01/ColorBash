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
    public Vector2 knockbackDistance;
    private float rotationTimer;
    public ParticleSystem explosion;
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rotationTimer = 0;
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

    protected virtual void OnCollisionEnter2D(Collision2D collision){
        if ( collision.gameObject.tag == "Player"){
            explosion.GetComponent<ParticleSystem>().Play();
        }
    }
    void Update(){
        gameObject.transform.RotateAround(gameObject.transform.position, new Vector3(0, 0, 1), -rotationSpeed);
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
