using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookmove : MonoBehaviour
{
    private int foodValue=0;
    private Renderer meatMat;
    private string stillcooking="y";
    [SerializeField]
    private Color colorToTurnTo = Color.white;

    void Start()
    {
        meatMat = GetComponent<Renderer>();
        StartCoroutine(cookTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown(){
        GetComponent<Transform>().position = new Vector3(-1.26f, .65f, 0);
        Gameflow.plateValue += foodValue;
        stillcooking = "n";
    }

    IEnumerator cookTimer(){
        yield return new WaitForSeconds(2);
        foodValue = 10;
        if (stillcooking=="y")
        meatMat.material.color = colorToTurnTo;
    }
}
