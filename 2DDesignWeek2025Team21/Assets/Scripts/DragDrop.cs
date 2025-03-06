using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler
    , IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    //[SerializeField] private Canvas canvas;

    [SerializeField] private bool isTile = true;
    [SerializeField] Image outline;
    [SerializeField] Image tile;
    [SerializeField] Canvas dragCanvas;
    Canvas newDragCanvas;
    Transform parentToStore;

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
        if (isTile)
        {
            tile.color = new Color32(56, 200, 171, 255);
        }

        //canvasGroup.alpha = 0.4f;

        //newDragCanvas = Instantiate(dragCanvas, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

        //parentToStore = gameObject.transform.parent;
        //newDragCanvas.transform.parent = parentToStore;
        //gameObject.transform.parent = newDragCanvas.transform;
        //newDragCanvas.overrideSorting = true;
        //newDragCanvas.sortingOrder = 1;
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
        /*if (shouldReset && isTile)
        {
            transform.position = originalPosition;
        }*/
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1;
        shouldReset = true;

        //tile.color = new Color32(200, 63, 56,255);
        if (isTile)
        {
            tile.color = new Color32(255, 255, 255, 255);
        }

        //gameObject.transform.parent = parentToStore;
        //Destroy(newDragCanvas);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isTile)
        {
            originalPosition = transform.position;
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (outline != null)
        {
            outline.enabled = true;
            Debug.Log("mouse hover");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (outline != null)
        {
            outline.enabled = false;
            Debug.Log("mouse off");
        }
    }
}
