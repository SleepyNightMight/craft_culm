using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftPos : MonoBehaviour
    
{
    public GameObject Sberry;
    public GameObject Cream;
    public GameObject Flour;
    public GameObject shortcake;

    public void CombineItem()
    {
        if (Sberry.transform.position.x >= -100 && Sberry.transform.position.x <= -70)
        {
            Debug.Log("OrderFilled");

        }
    }
}
