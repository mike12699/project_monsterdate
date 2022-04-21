using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyBadDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/(And he's... just as annoying as I thought he was! Great. Glad that this is my fate right now.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! PRAY, DIDST MINE CHARMS PLEASANTLY AFFECT THEE ON THIS EVENING?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... Sure! Yeah, they sure did! Had a good time at dinner, yes, sir!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THAT IS GOOD TO HEAR! IN MY MANY YEARS WITHOUT ROMANCE, I FEARED THAT I HAD GROWN RUSTY IN MY CRAFT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(I can only imagine why that was the case.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Think we gotta give ourselves a little bit more time, though, huh? Can't just say we're a couple right outta the gate.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE! KNOW THAT I HAVE MANY VENTURES PLANNED FOR US, SKULLY! I SHALL HOPE THOU ART EXCITED!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sure am, boss. Sure am.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Gods, lets hope he gets better at... /wait:0.5/not doing that.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[A week and a half later.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SKULLY! PRAY, COME TO MY SIDE! I WISH TO TAKEST THEE... /wait:0.5/OUT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, alright, Askarios, I'll bite.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully crosses his arms and smirks.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Where are ya takin' me?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/'TIS A SURPRISE! DON THINE BEST ATTIRE, FOR WE SHALL HAVE QUITE THE NICE EVENING TOGETHER!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully sighs, rolls his shoulders, then steps over to the bathroom. Less than thirty seconds later, he emerges, having changed absolutely nothing.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Alright, all dressed up.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERFECT! THAT OUTFIT IS QUITE DASHING ON THEE, SKULLY! WHERE DIDST THOU PURCHASE IT?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Ya think so? I made it myself.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios laughs, then claps Skully on the shoulder, letting out the sound of bone impacting with bone.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I DID NOT TAKE THEE FOR A TAILOR! PERHAPS THOU SHALL ASSIST IN IMPROVING MINE OWN WARDROBE'S CONTENTS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Sure, yeah. Now, can we get goin'?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/YES! LET US GO, SKULLY! ONWARD!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Behold... the ruler of Zyx, everyone! Sigh...)", "Skully"));
        var endText = new DialogData("/speed:0.03/Yeah, let's get this over with. Right behind ya, Askarios.", "Skully");

        endText.Callback = () => LoadSkullyEndDate();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadSkullyEndDate()
    {
        SceneManager.LoadScene("SkullyDateEnd");
    }
}
