using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class IntroSceneScriptPt3 : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/BY THE HELLS, IT IS BRIGHT HERE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/It's called the sun, boss. You just haven't seen it in centuries.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/CAN WE RID OURSELVES OF IT? IT IS MAKING MY BONES BLEACH!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I don't think it happens that fast.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios is bumped into by someone, leaving a smear of ketchup on his cloak from a stray French fry.]", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Move, jackass!", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WATCH THYSELF, KNAVE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Psst... Hey, boss, ya might wanna keep it down. Don't wanna make a bad first impression on your future partners, eh?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THAT ONE TOUCHED MY CLOAK WITH ITS DISGUSTING, FLESHY APPENDAGES! I SHALL CUT THEM FROM THEIR JOINTS AS PUNISHMENT! COME BACK HERE, PEASANT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios runs off to chase the individual responsible for dirtying his outfit.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss! Wait up!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully runs in the direction of Askarios's pursuit.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(This is gonna be a loooooong day.)", "Skully"));
        var endText = new DialogData("/speed:0.03/Alright, boss. Got a few profiles for ya to choose from. Doesn't matter which one you choose, ya just gotta pick who ya like. I conveniently laid 'em out for ya on this specially made user interface.", "Skully");

        endText.Callback = () => LoadCharacterSelection();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    private void LoadCharacterSelection()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
}
