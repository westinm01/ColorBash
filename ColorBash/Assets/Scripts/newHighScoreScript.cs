using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class newHighScoreScript : MonoBehaviour
{
    private GameManager gm;
    TextMeshProUGUI score; 
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "New High Score!\nPrevious Best: " + gm.oldHighScore;
    }
}
