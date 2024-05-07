using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerArray : MonoBehaviour
{
    [SerializeField]
    public List<Customer> ListOfCustomers;
    //public Customer Customers1;
    //public Customer Customers2;
    

    public void OrderTaken()
    {
        Destroy(ListOfCustomers[0]);
    }

    public void NextCustomer()
    {
        ListOfCustomers[1].enable = true;
    }
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
