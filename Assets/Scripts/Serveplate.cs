using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serveplate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown(){
        if (Gameflow.orderValue==Gameflow.plateValue){
            Debug.Log("correct");
        }
    }
}
