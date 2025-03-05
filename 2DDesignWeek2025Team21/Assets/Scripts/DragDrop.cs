using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler
    , IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //[SerializeField] private Canvas canvas;

    [SerializeField] private bool isTile = true;

    private RectTransform rectTransform;
    private Vector3 originalPosition;
    private CanvasGroup canvasGroup;

    private Vector3 mousePosition;
    public float moveSpeed = 0.07f;

    Vector3 mouseWorldPos;


    [HideInInspector] public bool shouldReset = true;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = new Vector3(0.0f, 0.0f, 0.0f);
        canvasGroup = GetComponent<CanvasGroup>();

        mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.4f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        //rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (shouldReset && isTile)
        {
            transform.position = originalPosition;
        }
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1;
        shouldReset = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isTile)
        {
            originalPosition = transform.position;
        }

    }
}
