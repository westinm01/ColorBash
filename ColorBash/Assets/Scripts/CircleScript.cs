using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public SpriteRenderer sp;
    public float rotationSpeed;
    public Vector2 knockbackDistance;

    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
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

    void Update(){
        gameObject.transform.RotateAround(gameObject.transform.position, new Vector3(0, 0, 1), -rotationSpeed);
    }

}
