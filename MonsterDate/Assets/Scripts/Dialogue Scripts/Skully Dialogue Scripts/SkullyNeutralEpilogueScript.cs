using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyNeutralEpilogueScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    void Start()
    {
        NeutralEpilogueStart();
    }

    #region Dialogue Start
    public void NeutralEpilogueStart()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/And so Askarios — Lich Lord of Skentira, Master of Undeath, Emperor of Zyx, and whatever other titles he liked to add in the moment — went on to romance his chosen paramour, seeking love eternal from their hearts.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/He found himself on a number of dates with each, some of which were successful, and in time, his search would come to an end.", "Skully"));
        var endText = new DialogData("/speed:0.03/Now, let’s see where that landed him, eh?", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => NeutralEpilogueEnd();
    }
    #endregion

    #region Dialogue End
    public void NeutralEpilogueEnd()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/After some heart-to-hearts, Askarios realized that he had been unappreciative of my work over the years of my servitude, but we both recognized that things might not work out in the end.", "Skully"));
        var endText = new DialogData("/speed:0.03/After some attempts at more dates, he decided to simply promote me to majordomo of Zyx, and I took a temporary absence to seek out my own partner to bone.", "Skully");

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
