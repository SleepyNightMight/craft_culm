using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingController : MonoBehaviour
{
    public GameObject currentItemOnHand;
    LayerMask layerToIgnore;
    Camera mainCam;

    private void Start()
    {
        mainCam = Camera.main;
    }

   /* public void Update()
    {
       
        RaycastHit hit;
        if (Physics.Raycast(mainCam.ScreenToWorldPoint(Input.mousePosition), Vector3.forward, out hit, layerToIgnore)) {           
            Debug.Log(hit.transform);
        }
        Debug.DrawRay(mainCam.ScreenToWorldPoint(Input.mousePosition), Vector3.forward * 1000);
        Debug.Log(mainCam.ScreenToViewportPoint(Input.mousePosition));
       
    }*/

}
