using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBlueprint : MonoBehaviour
{
    public Vector3 bigscale, smallscale, originalpos, bigpos;
    public bool isBig;
    // Start is called before the first frame update
    void Start()
    {       
        isBig = false;
    }

    private void OnMouseDown()
    {
        transform.localScale = isBig ? smallscale : bigscale;
        transform.position = isBig ? originalpos : bigpos;
        isBig = !isBig;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
