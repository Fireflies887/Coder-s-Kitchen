using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class MenuAnimation : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    [SerializeField] float duration;
    [SerializeField] LeanTweenType easeType;
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move(){
        LeanTween.moveY(gameObject, targetTransform.position.y, duration).setEase(easeType);
    }
}
