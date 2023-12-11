using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled2 : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject lybTea;

    public void Trigger()
    {
        if (lybTea.activeInHierarchy == false)
        {
            lybTea.SetActive(true);
        }
        else
        {
            lybTea.SetActive(false);
        }
    }
}
