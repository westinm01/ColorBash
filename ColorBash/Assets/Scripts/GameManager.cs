using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasStarted;
    public GameObject GameOverScreen;
    public AudioSource bgm;
    public bool newHighScore;
    public AudioClip HighScoreSound;

    public void StartGame(){
        hasStarted = true;
    }

    public void GameOver(){
        Debug.Log("Game Over");
        GameOverScreen.SetActive(true);
        if (newHighScore){
            AudioSource.PlayClipAtPoint(HighScoreSound, new Vector3(0, 0, 0));
        }
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

    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
        newHighScore = false;
        SaveData.LoadInfo();
        SaveData.SaveInfo();
    }
}
