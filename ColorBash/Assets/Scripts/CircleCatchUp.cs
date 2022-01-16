using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCatchUp : MonoBehaviour
{
    public float maxX;
    public float speedIncrease;

    private GameManager gm;

    void Start(){
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    void Update(){
        if (gm.hasStarted && gameObject.transform.position.x < maxX){
            gameObject.transform.position += new Vector3(speedIncrease, 0);
        }
    }
}
