using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemIconMovement : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler,IEndDragHandler
{

    public Vector3 initialPosition;
    RectTransform iconTransform;
    public Items itemData;
    public CraftingController craftingController;
    CanvasGroup canvasGroup;




    private void Start()
    {
        iconTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        GetComponent<Image>().sprite = itemData.itemIcon;

        if (itemData == null) {
            Debug.LogError("This prefab doesn't have a item asigned! Please asign one.");        
        }
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        iconTransform.position = Input.mousePosition;
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        initialPosition = iconTransform.position;
        craftingController.currentItemOnHand = gameObject;
        canvasGroup.blocksRaycasts = false;

    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        iconTransform.position = initialPosition;
    }
}
