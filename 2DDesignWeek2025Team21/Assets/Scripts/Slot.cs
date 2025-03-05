using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    bool shouldReset;
    [SerializeField] SlotManager manager;
    [SerializeField] string nameOfTileToLookFor;
    Vector2 storedPosition;
    bool isOccupied = false;
    GameObject tile;

    void Start()
    {
        storedPosition = new Vector2(0.0f, 0.0f);
    }

    void Update()
    {
        if (isOccupied)
        {
            if(tile.GetComponent<RectTransform>().anchoredPosition != storedPosition)
            {
                manager.SubtractTile();
                isOccupied = false;
            }
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            //if it has a should reset value
            if (eventData.pointerDrag.GetComponent<DragDrop>().shouldReset != null)
            {
                //set the should reset to false
                eventData.pointerDrag.GetComponent<DragDrop>().shouldReset = false;

                if (nameOfTileToLookFor == eventData.pointerDrag.name)
                {
                    manager.AddTile();
                    isOccupied = true;
                }
            }
            tile = eventData.pointerDrag;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            storedPosition = tile.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
