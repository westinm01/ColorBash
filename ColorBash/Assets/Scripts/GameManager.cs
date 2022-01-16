using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasStarted;

    public void StartGame(){
        hasStarted = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
    }
}
