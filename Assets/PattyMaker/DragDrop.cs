using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    //DragDrop
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
    }

        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("OnPointerDown");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        }
        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        }
 
    public void OnDrop(PointerEventData eventData)
        {
        throw new System.NotImplementedException();
        }


}