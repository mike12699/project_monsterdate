using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MyraNeutralEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Myra, finally coming into her post-university life, came to realize that Askarios might not be the proper fit for her personality, and she asked if he would be comfortable declaring their relationship as nothing more than friendship.", "Skully"));
        var endText = new DialogData("/speed:0.03/While disappointed, Askarios understood that he shouldn’t bring the girl more stress than she already faced, and their romance quickly became platonic.", "Skully");

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
