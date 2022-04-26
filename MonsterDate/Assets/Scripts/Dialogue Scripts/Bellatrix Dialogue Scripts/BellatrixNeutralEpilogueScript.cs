using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class BellatrixNeutralEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Bellatrix, having found popularity with the growth of the Carrion Creepers’s reputation, eventually lost out on her chances at romantic opportunities with Askarios.", "Skully"));
        var endText = new DialogData("/speed:0.03/While on good terms, they agreed that she wouldn’t have the time to properly show her love to him, and they have remained good friends to this day.", "Skully");

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
