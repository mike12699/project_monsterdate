using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MothmanGoodEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/After a few more weeks of vacationing, Greg eventually had to return to his home of Point Pleasant.", "Skully"));
        var endText = new DialogData("/speed:0.03/Askarios, having found himself in love with the man, joined him on his journey, and the two began to wreak havoc across the surrounding lands, with Greg bringing ill omens and Askarios fulfilling them.", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => LoadCredits();
    }
    #endregion

    void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
