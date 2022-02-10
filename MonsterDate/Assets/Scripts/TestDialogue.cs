using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class TestDialogue : MonoBehaviour
{
    public DialogManager dialogueManager;
    private void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("Hello there young one.", "Person 1"));
        dialogueTexts.Add(new DialogData("/emote:Happy/What is your /speed:down/name?", "Person 1"));
        dialogueTexts.Add(new DialogData("The name's Person 2", "Person 2"));
        dialogueTexts.Add(new DialogData("I see... /wait:1.0//emote:Happy/Nice to meet you!", "Person 1"));
        dialogueTexts.Add(new DialogData("/emote:Sad/Thanks for the invite by the way...", "Person 2"));

        dialogueManager.Show(dialogueTexts);
    }
}
