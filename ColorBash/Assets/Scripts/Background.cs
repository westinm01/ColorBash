using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Sprite[] backgrounds;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = backgrounds[Info.background];
    }
}