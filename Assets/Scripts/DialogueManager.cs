using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public List<Sprite> yuuriSprites; // List of Yuu-ri's sprites
    public List<Sprite> mercadoSprites; // List of Mr. Mercado's sprites
    public SpriteRenderer yuuriSpriteRenderer; // SpriteRenderer component for Yuu-ri's sprite
    public SpriteRenderer mercadoSpriteRenderer; // SpriteRenderer component for Mr. Mercado's sprite

    public Image blackScreen;
    public float fadeDuration = 1f;
    private Queue<(string speaker, string sentence, string expression)> dialogueQueue; // Modified the queue to include expression

    void Start()
    {
        dialogueQueue = new Queue<(string, string, string)>(); // Initialize the queue
    }

    public void StartDialogue(List<(string, string, string, bool, bool, string)> dialogue)
{
    dialogueQueue.Clear();

    foreach ((string speaker, string sentence, string spriteName, bool fadeOut, bool fadeIn, string expression) in dialogue)
    {
        dialogueQueue.Enqueue((speaker, sentence, expression)); // Enqueue the tuple
    }

    DisplayNextSentence();
}


    public void DisplayNextSentence()
    {
        if (dialogueQueue.Count == 0)
        {
            EndDialogue();
            return;
        }

        (string speaker, string sentence, string expression) = dialogueQueue.Dequeue();
        nameText.text = speaker;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        // Show the correct sprite based on the speaker and expression
        ShowSprite(speaker, expression);
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        float elapsedTime = 0f;
        Color currentColor = blackScreen.color;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            blackScreen.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }
    }

    IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        Color currentColor = blackScreen.color;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            blackScreen.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
        HideSprite();
    }

    void ShowSprite(string speaker, string expression)
{
    HideSprite();
    if (speaker == "Yuu-ri")
    {
        yuuriSpriteRenderer.gameObject.SetActive(true);
        switch (expression)
        {
            case "worried":
                yuuriSpriteRenderer.sprite = yuuriSprites[0]; // Assuming 'worried' expression is the first in the list
                break;
            case "thinking":
                yuuriSpriteRenderer.sprite = yuuriSprites[1]; // Assuming 'thinking' expression is the second in the list
                break;
            case "tearful":
                yuuriSpriteRenderer.sprite = yuuriSprites[2]; // Assuming 'tearful' expression is the third in the list
                break;
            case "shocked":
                yuuriSpriteRenderer.sprite = yuuriSprites[3]; // Assuming 'shocked' expression is the fourth in the list
                break;
            case "neutral":
                yuuriSpriteRenderer.sprite = yuuriSprites[4]; // Assuming 'neutral' expression is the fifth in the list
                break;
            case "explaining":
                yuuriSpriteRenderer.sprite = yuuriSprites[5]; // Assuming 'explaining' expression is the sixth in the list
                break;
            default:
                yuuriSpriteRenderer.sprite = yuuriSprites[4]; // Default to 'neutral' expression
                break;
        }
    }
    else if (speaker == "Mr. Mercado")
    {
        mercadoSpriteRenderer.gameObject.SetActive(true);
        switch (expression)
        {
            case "openmouth":
                mercadoSpriteRenderer.sprite = mercadoSprites[0]; // Assuming 'openmouth' expression is the first in the list
                break;
            case "neutral":
                mercadoSpriteRenderer.sprite = mercadoSprites[1]; // Assuming 'neutral' expression is the second in the list
                break;
            case "frowning":
                mercadoSpriteRenderer.sprite = mercadoSprites[2]; // Assuming 'frowning' expression is the third in the list
                break;
            default:
                mercadoSpriteRenderer.sprite = mercadoSprites[1]; // Default to 'neutral' expression
                break;
        }
    }
}


    void HideSprite()
    {
        yuuriSpriteRenderer.gameObject.SetActive(false);
        mercadoSpriteRenderer.gameObject.SetActive(false);
    }
}
