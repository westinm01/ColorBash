using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBoard
{
    public static void changeColorBoard(){
        if ( ScoreScript.scoreValue < 20 ){
            Debug.Log("Working");
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(false);
        }
        else if ( ScoreScript.scoreValue < 40 ){
            Debug.Log("Working2");
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(false);
        }
        else if ( ScoreScript.scoreValue < 60 ){
            Debug.Log("Working2");
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(false);
        }
        else if ( ScoreScript.scoreValue < 80 ){
            Debug.Log("Working2");
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
