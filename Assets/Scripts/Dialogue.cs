using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manmotion : MonoBehaviour
{
    public GameObject man;
    [SerializeField] Sprite newSprite;
    SpriteRenderer spriteRenderer;
    int count = 0;
    void Start()
    {
        spriteRenderer = man.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(new Vector2(1, 0) * Time.deltaTime);
        count++;
        if (count > 650)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}
