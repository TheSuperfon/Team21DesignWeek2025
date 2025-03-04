using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler
    , IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //[SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private Vector3 originalPosition;
    private CanvasGroup canvasGroup;

    [HideInInspector] public bool shouldReset = true;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = new Vector3(0.0f, 0.0f, 0.0f);
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.4f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (shouldReset)
        {
            transform.position = originalPosition;
        }
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1;
        shouldReset = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        originalPosition = transform.position;
    }
}
