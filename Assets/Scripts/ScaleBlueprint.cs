using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBlueprint : MonoBehaviour
{
    private Vector3 bigscale, smallscale, originalpos, bigpos;
    private bool isBig;
    // Start is called before the first frame update
    void Start()
    {
        bigscale = new Vector3 (4, 4, 4);
        smallscale = new Vector3(1, 1, 1);
        originalpos = new Vector3(-5, 2, 0);
        bigpos = new Vector3(0, 1, 0);
        
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
