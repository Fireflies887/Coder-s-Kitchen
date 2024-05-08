using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public string sceneName;
    public Animator animator;
    
    // void Update(){
    //     if (Input.GetMouseButtonDown(0)){
    //         FadeToLevel(0);
    //     }
    // }

    public void FadeToLevel (int levelIndex){
        animator.SetTrigger("FadeOut");
    }

    private void OnMouseDown()
    {
        if (gameObject.name=="play_button"){
            sceneName = "Story";
            OnFadeComplete();
        }

        if (gameObject.name=="grill_button"){
            sceneName = "GrillScene";
            OnFadeComplete();
        }

        if (gameObject.name=="counter_button"){
            sceneName = "CounterScene";
            OnFadeComplete();
        }
        
        if (gameObject.name=="pattymaker_button"){
            sceneName = "PattyMakerScene";
            OnFadeComplete();
        }

        if (gameObject.name=="compiler_button"){
            sceneName = "CompilerScene";
            OnFadeComplete();
        }
    }

    public void OnFadeComplete(){
        SceneManager.LoadScene(sceneName);
    }
    // public void LoadScene()
    // {
    //     SceneManager.LoadScene(sceneName);
    // }
}
