using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScoreText : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("UpdateScoreText", 0f, 1f);
    }

    void UpdateScoreText()
    {
        gameObject.GetComponent<Text>().text = "Points: " + Info.points;
    }
}
