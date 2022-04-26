using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyBadEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Askarios, despite recognizing that I was being underappreciated, couldn’t get over his ego, and he continued to treat me as he always had.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/After deciding that I’d had enough with my position, I declared that I would be quitting his service, and I left to wander the land in search of a means to break the enchantment that kept me alive, even if it would take me many years.", "Skully"));
        var endText = new DialogData("/speed:0.03/I’m comin’, ma. I’ll see you and my brothers when I get there.", "Skully");

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
