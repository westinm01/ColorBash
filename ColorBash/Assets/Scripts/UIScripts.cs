using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripts : MonoBehaviour
{
    public AudioClip cantBuyClip;
    public AudioClip buyClip;
    public AudioSource aud;

    private Vector3 playPoint = Vector3.zero;

    void Start(){
        aud = gameObject.GetComponentInParent<AudioSource>();
    }

    void PlayCantBuyClip(){
        aud.clip = cantBuyClip;
        aud.Play();
    }

    void PlayBuyClip(){
        aud.clip = buyClip;
        aud.Play();
    }

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
    public void UnlockCircleSerious()
    {
        SaveData.LoadInfo();
        if (Info.circles[1] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 100)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[1] = true;
        Info.points -= 100;
        SaveData.SaveInfo();
    }

    public void UnlockCircleBruh()
    {
        SaveData.LoadInfo();
        if (Info.circles[2] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 150)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[2] = true;
        Info.points -= 150;
        SaveData.SaveInfo();
    }

    public void UnlockCircleBlank()
    {
        SaveData.LoadInfo();
        if (Info.circles[3] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 200)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[3] = true;
        Info.points -= 200;
        SaveData.SaveInfo();
    }

    public void UnlockCirclePirate()
    {
        SaveData.LoadInfo();
        if (Info.circles[4] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 500)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[4] = true;
        Info.points -= 500;
        SaveData.SaveInfo();
    }

    public void UnlockCircleFlushed()
    {
        SaveData.LoadInfo();
        if (Info.circles[5] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 600)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[5] = true;
        Info.points -= 600;
        SaveData.SaveInfo();
    }

    public void UnlockCircleNinja()
    {
        SaveData.LoadInfo();
        if (Info.circles[6] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 800)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[6] = true;
        Info.points -= 800;
        SaveData.SaveInfo();
    }

    public void UnlockCircleNotACircle()
    {
        SaveData.LoadInfo();
        if (Info.circles[7] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 1100)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[7] = true;
        Info.points -= 1100;
        SaveData.SaveInfo();
    }

    public void UnlockCircleDog()
    {
        SaveData.LoadInfo();
        if (Info.circles[8] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 1500)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[8] = true;
        Info.points -= 1500;
        SaveData.SaveInfo();
    }

    public void UnlockCirclePizza()
    {
        SaveData.LoadInfo();
        if (Info.circles[9] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 2000)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[9] = true;
        Info.points -= 2000;
        SaveData.SaveInfo();
    }

    public void UnlockCircleCool()
    {
        SaveData.LoadInfo();
        if (Info.circles[10] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 2000)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[10] = true;
        Info.points -= 2000;
        SaveData.SaveInfo();
    }

    public void UnlockCircleChaos()
    {
        SaveData.LoadInfo();
        if (Info.circles[11] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 15000)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.circles[11] = true;
        Info.points -= 15000;
        SaveData.SaveInfo();
    }


    public void UnlockBackGroundSpace()
    {
        SaveData.LoadInfo();
        if (Info.backgrounds[0] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 100)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.backgrounds[0] = true;
        Info.points -= 100;
        SaveData.SaveInfo();
    }

    public void UnlockBackGroundBoreal()
    {
        SaveData.LoadInfo();
        if (Info.backgrounds[1] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 200)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.backgrounds[1] = true;
        Info.points -= 200;
        SaveData.SaveInfo();
    }

    public void UnlockBackGroundSummerSky()
    {
        SaveData.LoadInfo();
        if (Info.backgrounds[2] == true)
        {
            Debug.Log("Already own");
            PlayCantBuyClip();
            return;
        }
        if (Info.points < 300)
        {
            Debug.Log("Not enough points");
            PlayCantBuyClip();
            return;
        }
        PlayBuyClip();
        Info.backgrounds[2] = true;
        Info.points -= 300;
        SaveData.SaveInfo();
    }
}
