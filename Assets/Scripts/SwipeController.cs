using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    [SerializeField] int maxPage;
    int currentPage;
    Vector3 targetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform levelPagesRect;
    [SerializeField] float tweenTime;
    [SerializeField] LeanTweenType tweenType;

    private void Awake(){
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
    }

    void OnMouseDown(){
        if (gameObject.name=="fridge_downButton"){
            Down();
        }

        if (gameObject.name=="fridge_upButton"){
            Up();
        }
    }
    public void Down(){
        if (currentPage < maxPage){
            currentPage++;
            targetPos += pageStep;
            MovePage();
        }
    }

    public void Up(){
        if (currentPage > 1){
            currentPage--;
            targetPos -= pageStep;
            MovePage();
        }
    }

    void MovePage(){
        levelPagesRect.LeanMove(targetPos, tweenTime).setEase(tweenType);
    }
}
