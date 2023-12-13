using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled3 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject strawberryui;
    public GameObject cremeui;
    public GameObject vanillaui;
    public GameObject flourui;
    public GameObject lbTea;
    public GameObject whitept;
    public GameObject recname1;
    public GameObject recname2;
    public GameObject recname3;

    public void Trigger(){
        if (strawberryui.activeInHierarchy == true && cremeui.activeInHierarchy == true && vanillaui.activeInHierarchy == true && flourui.activeInHierarchy == true){
            strawberryui.SetActive(false);
            flourui.SetActive(false);
            vanillaui.SetActive(false);
            cremeui.SetActive(false);
           recname1.SetActive(false);
            
            lbTea.SetActive(true);
            recname2.SetActive(true);
        }
        else {
            if (strawberryui.activeInHierarchy == true && cremeui.activeInHierarchy == true && vanillaui.activeInHierarchy == true && flourui.activeInHierarchy == true)
            {
                strawberryui.SetActive(true);
                flourui.SetActive(true);
                vanillaui.SetActive(true);
                cremeui.SetActive(true);
                recname1.SetActive(true);

                lbTea.SetActive(false);
                recname2.SetActive(false);
            }
            else
            {
                lbTea.SetActive(false);
                recname2.SetActive(false);

                whitept.SetActive(true);
                recname3.SetActive(true);
            }
        }

    }
    
}
