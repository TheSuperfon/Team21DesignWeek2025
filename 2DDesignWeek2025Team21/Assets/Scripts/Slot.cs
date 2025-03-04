using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    bool shouldReset;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            //if it has a should reset value
            if (eventData.pointerDrag.GetComponent<DragDrop>().shouldReset != null)
            {
                //set the should reset to false
                eventData.pointerDrag.GetComponent<DragDrop>().shouldReset = false;
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
