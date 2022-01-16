using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwnedCircleText : MonoBehaviour
{
    public int index;

    private void Start()
    {
        InvokeRepeating("CheckForPurchase", 0, 2f);
    }

    public void CheckForPurchase()
    {
        if (Info.circles[index] == true)
        {
            GetComponent<Text>().text = "owned";
            gameObject.GetComponentInParent<Button>().interactable = false;
            CancelInvoke();
        }
    }
}
