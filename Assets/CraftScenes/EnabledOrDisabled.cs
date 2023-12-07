using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject strawcake;

    public void Trigger()
    {
        if(strawcake.activeInHierarchy == false)
        {
            strawcake.SetActive(true);
        }
        else
        {
            strawcake.SetActive(false);
        }
    }
}
