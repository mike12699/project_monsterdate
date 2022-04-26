using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class BellatrixBadEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Bellatrix’s band’s popularity eventually got to her head, and she soon came to forget about Askarios.", "Skully"));
        var endText = new DialogData("/speed:0.03/Blinded by her fame, she started to neglect keeping in touch, and once she began to tour the region, she never saw him again.", "Skully");

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
