using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyGoodDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region CharacterDialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/(Shit... Not me thinkin' the boss is a little—)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(No, stop it, Skully. Don't think about him that way — it ain't who you are!)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! ER, I MEAN, SKULLY! DIDST THOU ENJOYEST OUR EVENING OF FINE DINING?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully perks up in shock, then hastily rubs away the apparent blush from his cheeks, hiding it from view.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... Y-yeah, I guess so, boss. Er, uh— Askarios!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/WHAT IS WRONG, SKULLY? THOU SEEMEST DISTRACTED!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I-it's just the food coma settlin' in! Don't worry about it too much!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully quickly points to the dark spots under his eye sockets and rubs his sternum to punctuate his point.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios lets out a bellowing laugh.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/REST WELL, THEN, SKULLY, FOR WE STILL YET POSSESS MANY ROMANTIC TASKS TO PURSUE, BOTH AS A PAIR AND WITH THE DENIZENS OF THIS FAIR CITY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... Y-yeah, rest well, boss!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Fuck... This ain't good.)", "Skully"));
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
