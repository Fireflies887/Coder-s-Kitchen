using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickplace : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown(){
        if (gameObject.name=="BotBun")
        Instantiate(cloneObj, new Vector3(-1.26f, .10f, 0), cloneObj.rotation);

        if (gameObject.name=="TopBun")
        Instantiate(cloneObj, new Vector3(-1.26f, .60f, 0), cloneObj.rotation);

        if (gameObject.name=="ContainerCheese")
        Instantiate(cloneObj, new Vector3(-1.26f, .62f, 0), cloneObj.rotation);

        if (gameObject.name=="Ketchup_bottle")
        Instantiate(cloneObj, new Vector3(-1.26f, .64f, 0), cloneObj.rotation);

        if (gameObject.name=="Mayo_bottle")
        Instantiate(cloneObj, new Vector3(-1.26f, .64f, 0), cloneObj.rotation);

        if (gameObject.name=="Lettuce")
        Instantiate(cloneObj, new Vector3(-1.26f, .64f, 0), cloneObj.rotation);

        Gameflow.plateValue += foodValue;
        Debug.Log(Gameflow.plateValue+" "+Gameflow.orderValue);
    }
}
