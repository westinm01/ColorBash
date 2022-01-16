using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCircleUI : MonoBehaviour
{
    public void ChangeToCircleDefault(Sprite sprite)
    {
        if(Info.circles[0] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 0;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleSerious(Sprite sprite)
    {
        if (Info.circles[1] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 1;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleBruh(Sprite sprite)
    {
        if (Info.circles[2] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 2;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleBlank(Sprite sprite)
    {
        if (Info.circles[3] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 3;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCirclePirate(Sprite sprite)
    {
        if (Info.circles[4] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 4;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleFlushed(Sprite sprite)
    {
        if (Info.circles[5] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 5;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleNinja(Sprite sprite)
    {
        if (Info.circles[6] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 6;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleNotACircle(Sprite sprite)
    {
        if (Info.circles[7] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 7;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleDog(Sprite sprite)
    {
        if (Info.circles[8] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 8;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCirclePizza(Sprite sprite)
    {
        if (Info.circles[9] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 9;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleCool(Sprite sprite)
    {
        if (Info.circles[10] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 10;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToCircleChaos(Sprite sprite)
    {
        if (Info.circles[11] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.circle = 11;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToBackgroundSpace(Sprite sprite)
    {
        if (Info.backgrounds[0] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.background = 0;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToBackgroundStars(Sprite sprite)
    {
        if (Info.backgrounds[1] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.background = 1;
            SaveData.SaveInfo();
        }
    }

    public void ChangeToBackgroundBoreal(Sprite sprite)
    {
        if (Info.backgrounds[2] == true)
        {
            SaveData.LoadInfo();
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = sprite;
            Info.background = 2;
            SaveData.SaveInfo();
        }
    }
}
