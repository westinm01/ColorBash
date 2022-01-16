using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    private void Start()
    {
        SaveData.LoadInfo();
        GetComponent<TextMeshProUGUI>().text = "High Score: " + Info.highScore;
    }
}
