using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public SpriteRenderer sp;

    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
    }

    public void setColorRed(){
        Debug.Log("Setting color to red");
        sp.color = Color.red;
    }
}
