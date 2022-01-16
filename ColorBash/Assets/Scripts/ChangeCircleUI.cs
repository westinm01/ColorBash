using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCircleUI : MonoBehaviour
{
    public void ChangeToCircleDefault(Sprite sprite)
    {
        if(Info.circles[0] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleSerious(Sprite sprite)
    {
        if (Info.circles[1] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleBruh(Sprite sprite)
    {
        if (Info.circles[2] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleBlank(Sprite sprite)
    {
        if (Info.circles[3] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCirclePirate(Sprite sprite)
    {
        if (Info.circles[4] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleFlushed(Sprite sprite)
    {
        if (Info.circles[5] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleNinja(Sprite sprite)
    {
        if (Info.circles[6] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleNotACircle(Sprite sprite)
    {
        if (Info.circles[7] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleDog(Sprite sprite)
    {
        if (Info.circles[8] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCirclePizza(Sprite sprite)
    {
        if (Info.circles[9] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleCool(Sprite sprite)
    {
        if (Info.circles[10] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToCircleChaos(Sprite sprite)
    {
        if (Info.circles[11] == true)
        {
            GameObject.Find("Circle").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToBackgroundSpace(Sprite sprite)
    {
        if (Info.backgrounds[0] == true)
        {
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToBackgroundStars(Sprite sprite)
    {
        if (Info.backgrounds[1] == true)
        {
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    public void ChangeToBackgroundBoreal(Sprite sprite)
    {
        if (Info.backgrounds[2] == true)
        {
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }
}
