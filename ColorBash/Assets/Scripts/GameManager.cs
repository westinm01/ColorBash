using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasStarted;
    public bool canFlip;
    public GameObject spawner;
    public GameObject reverseSpawner;
    public GameObject GameOverScreen;
    public GameObject newHighScoreScreen;
    public AudioSource bgm;
    public bool newHighScore;
    public AudioClip HighScoreSound;
    public int oldHighScore;

    public void StartGame(){
        hasStarted = true;
        SaveData.LoadInfo();
        oldHighScore = Info.highScore;
        ColorBoard.changeColorBoard();
        // reverseSpawner.GetComponent<SquareSpawner>().canSpawn = false;

    }

    public void GameOver(){
        Debug.Log("Game Over");
        GameOverScreen.SetActive(true);
        if (newHighScore){
            Debug.Log("New high score detected");
            newHighScoreScreen.SetActive(true);
            AudioSource.PlayClipAtPoint(HighScoreSound, new Vector3(0, 0, 0));
        }
        reverseSpawner.GetComponent<SquareSpawner>().canSpawn = false;
        hasStarted = false;
        Time.timeScale = 0;
        bgm.Pause();
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void ExitToMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // StartGame();
    }

    public void EnableFlip(){
        if (canFlip){
            reverseSpawner.GetComponent<SquareSpawner>().canSpawn = true;
            spawner.GetComponent<SquareSpawner>().maxShapes = 3;        
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
        newHighScore = false;
        ScoreScript.scoreValue = 0;
        SaveData.LoadInfo();
        SaveData.SaveInfo();
    }
}
