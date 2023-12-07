using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Craft : MonoBehaviour, IDropHandler
{
    public Craft boxToCompareTo;
    public GameObject resultBox;
    public CraftingController craftingController;

    public Items currentItem;
    public GameObject itemPrefab;



    void CheckOtherBox() {
        if (boxToCompareTo.currentItem != null) {

            foreach (var recipe in boxToCompareTo.currentItem.isUsedWith)
            {
                if (recipe.item1 == boxToCompareTo.currentItem) {
                    if (recipe.item2 == currentItem) {
                        GameObject newItem = Instantiate(itemPrefab, resultBox.GetComponent<RectTransform>().transform);
                        newItem.GetComponent<ItemIconMovement>().itemData = recipe.itemToProduce;
                        newItem.GetComponent<Image>().sprite = recipe.itemToProduce.itemIcon;
                        newItem.GetComponent<ItemIconMovement>().craftingController = craftingController;
                       
                    }
                }
                else if (recipe.item2 == boxToCompareTo.currentItem)
                {
                    if (recipe.item1 == currentItem)
                    {
                        GameObject newItem = Instantiate(itemPrefab, resultBox.transform);
                        newItem.GetComponent<ItemIconMovement>().itemData = recipe.itemToProduce;
                        newItem.GetComponent<Image>().sprite = recipe.itemToProduce.itemIcon;
                        newItem.GetComponent<ItemIconMovement>().craftingController = craftingController;
                        
                    }
                }
            }
       
        }
    
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0) { 
        Debug.Log("Item added");
        craftingController.currentItemOnHand.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
        craftingController.currentItemOnHand.GetComponent<ItemIconMovement>().enabled = false;
        craftingController.currentItemOnHand.transform.SetParent(transform);
        currentItem = craftingController.currentItemOnHand.GetComponent<ItemIconMovement>().itemData;
        CheckOtherBox();
        StartCoroutine(BadFix());
    }
        
    }

    IEnumerator BadFix() {
        yield return new WaitForSeconds(.2f);
        craftingController.currentItemOnHand.GetComponent<ItemIconMovement>().enabled = true;
        craftingController.currentItemOnHand = null;

    }
}
