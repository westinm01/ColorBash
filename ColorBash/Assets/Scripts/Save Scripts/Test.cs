using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveType data = SaveData.LoadInfo();
        Debug.Log(Info.points);
        ++Info.points;
        SaveData.SaveInfo();
        Debug.Log(Info.points);
    }
}
