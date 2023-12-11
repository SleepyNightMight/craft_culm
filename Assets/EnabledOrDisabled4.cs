using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled4 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject WPT;

    public void Trigger()
    {
        if (WPT.activeInHierarchy == false)
        {
            WPT.SetActive(true);
        }
        else
        {
            WPT.SetActive(false);
        }
    }
}
