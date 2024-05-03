using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public delegate void DragEndedDelegate(Draggable draggableObject);
    public DragEndedDelegate dragEndedCallback;
    private bool isDragged = false;
    private bool hasBeenSnapped = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;
    private Renderer meatMat;
    private string stillcooking = "y";
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    private bool hasBeenClickedOrSnapped = false;

    void Start()
    {
        meatMat = GetComponent<Renderer>();
        StartCoroutine(cookTimer());
    }

    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
        SetClickedOrSnapped();
    }

    private void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;

        if (dragEndedCallback != null)
        {
            dragEndedCallback(this);
        }
    }

    public void SetClickedOrSnapped()
    {
        hasBeenClickedOrSnapped = true;
    }
    public void SetSnapped()
    {
        hasBeenSnapped = true;
    }

    IEnumerator cookTimer()
    {
        yield return new WaitUntil(() => hasBeenSnapped);
        yield return new WaitForSeconds(2);
        if (stillcooking == "y" && hasBeenClickedOrSnapped)
        {
            meatMat.material.color = colorToTurnTo;
        }
    }
}
