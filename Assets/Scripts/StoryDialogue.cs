using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StoryDialogue
{
    public string charName;
    [TextArea(3,10)]
    public string[] sentences;
}
