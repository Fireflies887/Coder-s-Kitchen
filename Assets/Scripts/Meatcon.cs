using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meatcon : MonoBehaviour
{
    public Transform cloneObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if(gameObject.name=="UncookedPatty")
            Instantiate(cloneObj, new Vector3(-4.08f,-2.52f,0), cloneObj.rotation);
            gameObject.GetComponent<Renderer>().enabled = false;
    }
}
