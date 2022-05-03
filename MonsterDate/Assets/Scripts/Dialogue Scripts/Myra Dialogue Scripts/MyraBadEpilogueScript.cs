using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MyraBadEpilogueScript : MonoBehaviour
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
        var endText = new DialogData("/speed:0.03/Now, let’s see where that landed him, eh?", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => BadEpilogueEnd();
    }
    #endregion

    #region Dialogue End
    public void BadEpilogueEnd()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/Myra, while coming to learn more about herself after graduating from university, realized that Askarios’s personality clashed too harshly with her own.", "Skully"));
        var endText = new DialogData("/speed:0.03/Avoiding the stress of conflict, she chose to ghost the lich on all of his romantic advances, and eventually faded into memory as she adopted the life of an underground art sensation.", "Skully");

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