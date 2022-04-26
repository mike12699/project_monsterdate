using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MothmanNeutralEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Greg continued to have philosophical discussions with Askarios until his vacation came to an end.", "Skully"));
        var endText = new DialogData("/speed:0.03/Having travelled back to Point Pleasant, he occasionally keeps in contact with the lich, but they both thought it best to return to their homes and, with newfound philosophies, improve the status quo of their lands.", "Skully");

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
