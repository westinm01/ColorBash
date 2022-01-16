using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSelection : MonoBehaviour
{
    // Start is called before the first frame update
    public bool inCircle;
    public GameObject circles;
    public GameObject backgrounds;
    void Start()
    {
        inCircle=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void switchSelection(){
    	if(inCircle){
    		circles.SetActive(false);
    		backgrounds.SetActive(true);
    		inCircle=false;
    	}
    	else{
    		circles.SetActive(true);
    		backgrounds.SetActive(false);
    		inCircle=true;
    	}
    }
    void setInCircle(){

    }
    void switchToCircle(){

    }
    void switchToBackground(){

    }
}
