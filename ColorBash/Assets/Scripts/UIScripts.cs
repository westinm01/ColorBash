using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripts : MonoBehaviour
{
    public void ChangeToCircleShop()
    {
        GameObject.Find("ShopMenu").transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        GameObject.Find("ShopMenu").transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
    }

    public void ChangeToBackgroundShop()
    {
        GameObject.Find("ShopMenu").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        GameObject.Find("ShopMenu").transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
    }

    public void BackToMainMenu()
    {
        GameObject.Find("ShopMenu").SetActive(false);
        for (int i = 0; i < GameObject.Find("MainMenu").transform.childCount; ++i)
        {
            GameObject.Find("MainMenu").transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
