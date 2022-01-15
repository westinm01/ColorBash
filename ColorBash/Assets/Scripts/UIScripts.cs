using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripts : MonoBehaviour
{
    public void ChangeToCircleShop()
    {
        GameObject.Find("Canvas").transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
    }

    public void ChangeToBackgroundShop()
    {
        GameObject.Find("Canvas").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
    }
}