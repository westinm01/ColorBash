using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBackgrounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateLocks", 0, 2f);
    }

    void UpdateLocks()
    {
        SaveData.LoadInfo();
        for (int i = 0; i < 3; ++i)
        {
            if (Info.backgrounds[i] == true)
            {
                gameObject.transform.GetChild(3 + i).gameObject.SetActive(false);
            }
        }
    }
}
