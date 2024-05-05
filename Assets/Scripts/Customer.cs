using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private Vector3 targetPosition = new Vector3(-1, -2, 0);
    public float movementSpeed = 5f;


    void Start()
    {

    }


    void Update()
    {
        Vector3 moveDirection = targetPosition - transform.position;

        moveDirection.Normalize();


        transform.Translate(moveDirection * movementSpeed * Time.deltaTime);


        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {

            transform.position = targetPosition;
        }
    }
}
