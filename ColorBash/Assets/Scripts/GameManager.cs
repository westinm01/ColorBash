using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasStarted;
    public GameObject GameOverScreen;

    public void StartGame(){
        hasStarted = true;
    }

    public void GameOver(){
        Debug.Log("Game Over");
        GameOverScreen.SetActive(true);
        hasStarted = false;
        Time.timeScale = 0;
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void ExitToMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // StartGame();
    }

    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
        SaveData.LoadInfo();
        SaveData.SaveInfo();
    }
}
