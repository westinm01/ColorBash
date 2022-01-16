using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBoard
{
    public static void changeColorBoard(){
        if ( ScoreScript.scoreValue < 150 ){
            Debug.Log("Working");
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(2).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(3).gameObject.SetActive(false);
        }
        else if ( ScoreScript.scoreValue < 300 ){
            Debug.Log("Working2");
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(2).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(3).gameObject.SetActive(false);
        }
        else if ( ScoreScript.scoreValue < 450 ){
            Debug.Log("Working2");
            GameObject.Find("ControlPanel").transform.GetChild(2).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(3).gameObject.SetActive(false);
        }
        else{
            Debug.Log("Working2");
            GameObject.Find("ControlPanel").transform.GetChild(3).gameObject.SetActive(true);
            GameObject.Find("ControlPanel").transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("ControlPanel").transform.GetChild(2).gameObject.SetActive(false);
        }
    }
}
