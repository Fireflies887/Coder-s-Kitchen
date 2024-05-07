using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class DialogueTrigger : MonoBehaviour
{
    void Start(){
        TriggerDialogue();
    }
    public void TriggerDialogue()
    {
        DialogueManager dialogueManager = FindObjectOfType<DialogueManager>();
        if (dialogueManager != null)
        {
            List<(string, string, string, bool, bool, string)> dialogue = new List<(string, string, string, bool, bool, string)>
            {
                ("You", "I can't believe this is happening...", "", false, false, ""),
                ("Yuu-ri", "Don't worry!", "yuuri_worried", false, false, "worried"),
                ("Yuu-ri", "I'm sure there's a solution to this...", "yuuri_worried", false, false, "worried"),
                (" ", "Your family runs a restaurant known for its unique burgers.", "", false, false,""),
                (" ", "But over time, the restaurant is drowning in debt.","", false, false,""),
                (" ", "With your family's lack of funds, the restaurant is doomed to shut down.","",false, false,""),
                ("You", "What are we supposed to do now...","",false,false,""),
                ("Yuu-ri", "Hang in there!","yuuri_worried",false,false,"worried"),
                ("Yuu-ri", "I'll definitely find help for us!","yuuri_tearful", false, false, "tearful"),
                ("Man", "Looks like you're having a hard time.","man_openmouth", false, false, "opemmouth"),
                ("Yuu-ri", "A customer?", "yuuri_shocked", true, true, "shocked"),
                ("You", "Sorry, but we're closed.","",false,false,""),
                ("Man", "Hi there! The name's Mr. Mercado","man_neutral", false, false, "neutral"),
                ("Mr. Mercado", "Wowee, this place sure is in low spirit. What happened to this place?","man_frowning", false, false,"frowning"),
                ("Yuu-ri", "Well, it's like this...", "yuuri_worried", false, false, "worried"),
                ("Mr. Mercado", "Oh? A debt huh? Hm...","man_frowning", false, false,"frowning"),
                ("Mr. Mercado", "Can I lend a hand?","man_neutral",false,false,"neutral"),
                ("Mr. Mercado", "Oh, of course I can lend a hand!","man_openmouth",false,false,"openmouth"),
                ("You", "He answered his own question...","",false,false,""),
                ("Yuu-ri", "You... Want to help us?","yuuri_shocked", false, false, "shocked"),
                ("Yuu-ri", "But how?","yuuri_thinking", false, false, "thinking"),
                ("Mr. Mercado", "I will invest in this place!","man_openmouth",false, false,"openmouth"),
                ("You", "Wh... HUUUUH?!","",false,false,""),
                ("Yuu-ri", "What?!","yuuri_shocked", false, false, "shocked"),
                ("Yuu-ri", "According to my data, business men are risky, but they certaily don't risk an obvious fail!", "yuuri_thinking", false, false, "thinking"),
                ("Mr. Mercado", "I've invested in numerous businesses with potential, and yours is one of them.","man_openmouth",false, false,"openmouth"),
                ("Mr. Mercado", "I also want to help Auntie May anytime she may need be.","man_neutral",false,false,"neutral"),
                ("You", "Auntie May? My mother?","",false,false,""),
                ("Mr. Mercado", "Yup! You see,","man_neutral",false,false,"neutral"),
                ("Mr. Mercado", "One day, when I was penniless and hungry,","man_frowning", false,false,"frowning"),
                ("Mr. Mercado", "A kind woman approached me and offered me a burger.","man_neutral", false, false, "neutral"),
                ("Mr. Mercado", "I was at my lowest, I even thought I was about to die.","man_frowning", false, false, "frowning"),
                ("Mr. Mercado", "Everyday, ever since that day,","man_frowning", false, false, "frowning"),
                ("Mr. Mercado", "She would stop by to give me a meal even though I never asked for more.","man_neutral", false, false, "neutral"),
                ("Mr. Mercado", "Without that random act of kindness, I doubt I would have been able to go on.","man_neutral", false, false,"neutral"),
                ("Mr. Mercado", "With her help, I was able to apply for a job.","man_neutral", false, false,"neutral"),
                ("Mr. Mercado", "It took years of hard work, and here I am now.","man_openmouth", false, false,"openmouth"),
                ("Mr. Mercado", "I want to repay the warmth your mother gave me. That's why I'm here.","man_neutral",false,false,"neutral"),
                ("Yuu-ri", "Oh, what a touching story! Miss May is truly an angel!","yuuri_tearful", false, false, "tearful"),
                ("You", "sobs","",false, false,""),
                ("Mr. Mercado", "Haha, I adore her for that.","man_openmouth", false, false, "neutral"),
                ("Mr. Mercado", "Well, let's get down to business.","man_neutral", false, false,"neutral"),
                ("Mr. Mercado", "What had happened that made this restaurant downhill?","man_frowning", false, false,"frowning"),
                ("Yuu-ri", "Oh, allow me to explain!","yuuri_worried", false, true, "worried"),
                (" ", "Yuu-ri then gave a brief explanation to Mr. Mercado", "", false, true, ""),
                ("Yuu-ri", "That's the gist of it!", "yuuri_neutral", true, false, "neutral"),
                ("Mr. Mercado", "Hm, your family simply needs to adapt to market changes.","man_neutral",false,false,"neutral"),
                ("Mr. Mercado", "Why not innovate and transform creative ideas into new solutions that can drive growth and efficiency?","man_openmouth",false,false,"openmouth"),
                ("You", "Yuu-ri, translate to monkey language.","",false,false,""),
                ("Yuu-ri", "Don't worry! I took note of this in my data.", "yuuri_thinking", false, false, "thinking"),
                ("Yuu-ri", "Oh, allow me to explain!", "yuuri_explaining", true, false, "explaining"),
                ("Yuu-ri", "Basically, we need a well planned strategy to run the place!", "yuuri_neutral", false, true, "neutral"),
                ("Mr. Mercado", "Mhm. The question is, how can we use innovation to our advantage?","man_neutral",false, false,"neutral"),
                ("Mr. Mercado", "We are, after all in the advanced era.","man_openmout", false, false,"openmouth"),
                ("Yuu-ri", "Hmm...", "yuuri_thinking", false, false,"thinking"),
                ("Yuu-ri", "Oh! Why don't we incorporate technology into cooking?","yuuri_explaining", false, false, "explaining"),
                ("Yuu-ri", "We can infuse the use of scripts to modify our recipes in a creative way.", "yuuri_explaining", true, true,"explaining"),
                ("Yuu-ri", "People nowadays use scripts in almost everything.", "yuuri_explaining", false, false, "explaining"),
                ("Mr. Mercado", "Just like those Holo-Sites you see on the road, they're structured using HTML.","man_openmouth", false, false,"openmouth"),
                ("You", "That's a great idea, actually.","",false,false,""),
                ("Mr. Mercado", "Well then, that settles it.","man_neutral", false,false,"neutral"),
                ("Mr. Mercado", "Allow me to provide you equipments.","man_openmouth",false,false,"openmouth"),
                ("Yuu-ri", "wow!", "yuuri_shocked", false, false, "shocked"),
                ("Yuu-ri", "There's so much stuff!", "yuuri_shocked", false, false, "shocked"),
                ("You", " So this is the power of the rich..!","",false,false,""),
                ("Yuu-ri", "oh, oh! let me arrange all of these!", "yuuri_explaining", false, false, "explaining"),
                (" ", "Yuuri enthusiastically scans each and every item.","",false,false,""),
                (" ", "Yuuri took them all at lightning speed, arranging them at their respective stations.","",true,false,""),
                ("Yuu-ri", "phew! Look at that!", "yuuri_neutral", false, true, "neutral"),
                ("You", "wow...","",false,false,""),
                ("Mr. Mercado", "I want you to try out these items.","man_openmouth",false,false,"openmouth"),
                ("Mr. Mercado", "I'll be your very first customer.","man_neutral",false,false,"neutral"),
                ("You", "I-I'll try my best!","",false,false,""),
                ("Yuu-ri", "Don't worry! I'll help you be familiar with all of it!", "yuuri_explaining", false, false,"explaining")
            };

            dialogueManager.StartDialogue(dialogue);

        }
    }
    void EndDialogue()
    {
        Debug.Log("End of Conversation");
        SceneManager.LoadScene("PattyMakerScene");
    }
}
