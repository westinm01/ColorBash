using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopScoreText : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("UpdateScoreText", 0f, 1f);
    }

    void UpdateScoreText()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Points: " + Info.points;
    }
}
