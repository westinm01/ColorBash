using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveType
{
    public int points;
    public int highScore;
    public bool[] circles = { true, false, false, false, false, false, false, false, false, false, false, false };
    public bool[] backgrounds = {true, false, false };
    public int circle; 
    public int background;

    public SaveType(int points_, bool[] circles_, bool[] backgrounds_, int highScore_, int circle_, int background_)
    {
        points = points_;
        circles = circles_;
        backgrounds = backgrounds_;
        highScore = highScore_;
        circle = circle_;
        background = background_;
        
    }
}
