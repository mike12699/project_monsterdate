using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class EyevanGoodEpilogueScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    void Start()
    {
        GoodEpilogueStart();
    }

    #region Dialogue Start
    public void GoodEpilogueStart()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/And so Askarios — Lich Lord of Skentira, Master of Undeath, Emperor of Zyx, and whatever other titles he liked to add in the moment — went on to romance his chosen paramour, seeking love eternal from their hearts.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/He found himself on a number of dates with each, many of which were successful, and in time, his search would come to an end.", "Skully"));
        var endText = new DialogData("/speed:0.03/Now, let’s see where that landed him, eh?", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => GoodEpilogueEnd();
    }
    #endregion

    #region Dialogue End
    public void GoodEpilogueEnd()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/Eyevan, originally thinking to simply use Askarios for his own betterment, found himself enjoying the lich’s company more and more as his education in necromancy continued.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Eventually, he confessed his love to Askarios, and they became the joint rulers of Zyx, bringing destruction and domination to all who opposed them.", "Skully"));
        var endText = new DialogData("/speed:0.03/Impressed with Eyevan’s knack for commanding death, Askarios would offer to make his lover a lich, and their egotistical, undead dominion has continued to this day.", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => LoadCharacterSelection();
    }
    #endregion

    void LoadCharacterSelection()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
}
