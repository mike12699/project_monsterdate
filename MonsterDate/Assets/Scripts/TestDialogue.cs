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

        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/A LICHYARD? MY, MY, THIS PARAMOUR-TO-BE HAS AN AFFINITY FOR THE UNDEAD, THEN?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, all I know is that they come here often.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERHAPS THEY ARE A LICH THEMSELVES! I WOULD SO ADORE TO SPOT ANOTHER OF MY KIND AND CRAFT.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Sad/Eh... /wait:0.5/ya didn't look at the picture I gave you, huh, boss?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NO! WAS I SUPPOSED TO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Can you keep it down, please? I'm trying to find inspiration here.", "Bellatrix"));

        dialogueManager.Show(dialogueTexts);
    }
}
