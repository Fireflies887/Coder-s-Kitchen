using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer2Dialogue : MonoBehaviour
{
    public GameObject man2;
    [SerializeField] Sprite newSprite;
    SpriteRenderer spriteRenderer;
    int count = 0;
    void Start()
    {
        spriteRenderer = man2.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(new Vector2(1, 0) * Time.deltaTime);
        count++;

        if (count > 850)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}
