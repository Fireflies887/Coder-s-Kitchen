using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer2 : MonoBehaviour
{
   private Vector3 targetPosition = new Vector3 (6, 0, 0);
    public float movespeed = 4f;
    int count = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;

        Vector3 moveDirection = targetPosition - transform.position;
        moveDirection.Normalize();
        transform.Translate(moveDirection * movespeed * Time.deltaTime);

        if (count > 8)
        {

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                transform.position = targetPosition;
            }
        }
    }
}
