using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject Panel;
    private bool itemDropped = false; 

    public void OpenPanel()
    {
        if (Panel != null && itemDropped) 
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            itemDropped = false; 
        }
    }

    public void ItemDropped() 
    {
        itemDropped = true;
    }
}
