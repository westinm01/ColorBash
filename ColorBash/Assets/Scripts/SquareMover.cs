using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public float squareSpeed;
   void Update(){
       gameObject.transform.position += new Vector3(-squareSpeed, 0) * Time.deltaTime;
   }
}
