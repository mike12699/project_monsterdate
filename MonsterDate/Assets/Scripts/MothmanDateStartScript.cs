using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class MothmanDateStartScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    private void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/A BEACH? /wait:0.5/I DID NOT PLAN TO BRING ATTIRE FOR SWIMMING ON THIS EXCURSION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You have a swimsuit, boss?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE I DO! DO YOU BELIEVE THAT I WOULD WILLINGLY SUBMERGE MY TYPICAL ATTIRE IN THE BLOOD LAKES OF ZYX? /wait:0.5/THEY ARE FAR TOO EXPENSIVE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AND IT IS AN HONOR GAZE UPON MY BARE BONES AS I SLOWLY EMERGE FROM THE WATERS, DRIPPING SENSUALLY FROM EACH AND EVERY CAVITY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, boss, can't say I relate to that feeling.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Don't gotta wear a swimsuit if you're dead, /speed:0.2/maaaan...", "Mothman"));

        dialogueManager.Show(dialogueTexts);
    }
}
