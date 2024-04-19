using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseMove : MonoBehaviour
{
    public Sprite snappedSprite;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(meltTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator meltTimer(){
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        yield return new WaitForSeconds(.5f);
            spriteRenderer.sprite = snappedSprite;
    }
}
