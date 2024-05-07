using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryFade : MonoBehaviour
{
    public Animator animator;

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            FadeToLevel(0);
        }
    }

    public void FadeToLevel (int levelIndex){
        animator.SetTrigger("Fade");
    }
}
