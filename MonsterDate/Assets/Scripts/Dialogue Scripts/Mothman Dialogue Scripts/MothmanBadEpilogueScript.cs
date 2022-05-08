using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MothmanBadEpilogueScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    void Start()
    {
        BadEpilogueStart();
    }

    #region Dialogue Start
    public void BadEpilogueStart()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/And so Askarios — Lich Lord of Skentira, Master of Undeath, Emperor of Zyx, and whatever other titles he liked to add in the moment — went on to romance his chosen paramour, seeking love eternal from their hearts.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/He found himself on a number of dates with each, none of which were successful, and in time, his search would come to an end.", "Skully"));
        var endText = new DialogData("/speed:0.03//emote:Smug/Now, let’s see where that landed him, eh?", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => BadEpilogueEnd();
    }
    #endregion

    #region Dialogue End
    public void BadEpilogueEnd()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/Greg, in a rare moment of lucidity, came to realize that Akarios didn’t suit his vibe, and his communications with the lich began to dwindle, especially once he returned to Point Pleasant.", "Skully"));
        var endText = new DialogData("/speed:0.03/After some months, they ceased entirely, but murmurs of ill omens soon began to permeate the lands of Zyx.", "Skully");

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
