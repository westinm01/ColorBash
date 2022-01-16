using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSkins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveData.LoadInfo();
        for (int i =0; i < 11; ++i)
        {
            if (Info.circles[i + 1] == true)
            {
                gameObject.transform.GetChild(12 + i).gameObject.SetActive(false);
            }
        }
    }
}
