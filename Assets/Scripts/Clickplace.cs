using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickplace : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;
    public AudioSource KetchupSplat;
    public static int sortingOrder = 1;
	private SpriteRenderer sprite;

    void Start()
    {
        KetchupSplat.playOnAwake = false;
    }

    private void playsound(){
        KetchupSplat.Play();
    }

    private void OnMouseDown(){

        sprite = GetComponent<SpriteRenderer>();

        if (gameObject.name=="BotBun"){
            Transform newObj = Instantiate(cloneObj, new Vector3(0.03f, .62f, 0), cloneObj.rotation);
            sortingOrder++;
            newObj.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
            playsound();
        }

        if (gameObject.name=="TopBun"){
            Transform newObj = Instantiate(cloneObj, new Vector3(0.03f, .62f, 0), cloneObj.rotation);
            sortingOrder++;
            newObj.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
            playsound();
        }
        
        if (gameObject.name=="ContainerCheese"){
            Transform newObj = Instantiate(cloneObj, new Vector3(0.03f, .62f, 0), cloneObj.rotation);
            sortingOrder++;
            newObj.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
            playsound();
        }
        

        if (gameObject.name=="Ketchup_bottle"){
            Transform newObj = Instantiate(cloneObj, new Vector3(0.03f, .62f, 0), cloneObj.rotation);
            sortingOrder++;
            newObj.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
            playsound();
        }

        if (gameObject.name=="Mayo_bottle"){
            Transform newObj = Instantiate(cloneObj, new Vector3(0.03f, .62f, 0), cloneObj.rotation);
            sortingOrder++;
            newObj.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
            playsound();
        }

        if (gameObject.name=="Lettuce"){
            Transform newObj = Instantiate(cloneObj, new Vector3(0.03f, .62f, 0), cloneObj.rotation);
            sortingOrder++;
            newObj.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
            playsound();
        }

        Gameflow.plateValue += foodValue;
        Debug.Log(Gameflow.plateValue+" "+Gameflow.orderValue);

    }
    
}
