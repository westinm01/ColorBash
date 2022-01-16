using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasStarted;

    public void StartGame(){
        hasStarted = true;
    }

    public void GameOver(){
        Debug.Log("Game Over");
        hasStarted = false;
        Time.timeScale = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
    }
}
