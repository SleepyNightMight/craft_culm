using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddToInventory : MonoBehaviour, IDropHandler
{
    public CraftingController craftingController;
    public Craft craftBox1;
    public Craft craftBox2;
    public GameObject resultBox;

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
      

        //craft item
        if (craftingController.currentItemOnHand.transform.parent == resultBox.transform)
        {
            craftBox1.currentItem = null;
            craftBox2.currentItem = null;
            Destroy(craftBox1.transform.GetChild(0).gameObject);
            Destroy(craftBox2.transform.GetChild(0).gameObject);    
        }
        //reset crafting
        else
        {
   

            if (craftBox1.transform.childCount > 0 && craftingController.currentItemOnHand.transform.parent == craftBox1.transform)
            {
                craftBox1.transform.GetChild(0).SetParent(transform);
                craftBox1.currentItem = null;

            }
            if (craftBox2.transform.childCount > 0 && craftingController.currentItemOnHand.transform.parent == craftBox2.transform)
            {
                craftBox2.transform.GetChild(0).SetParent(transform);
                craftBox2.currentItem = null;

            }
            if (resultBox.transform.childCount > 0)
            {
                Destroy(resultBox.transform.GetChild(0).gameObject);
            }
        }

        craftingController.currentItemOnHand.transform.SetParent(transform);
        craftingController.currentItemOnHand = null;


    }



}
