using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_rightTrashDoor : MonoBehaviour
{
    public Sprite testsample;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Move();
    }

    void Move()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = testsample;
    }
}
