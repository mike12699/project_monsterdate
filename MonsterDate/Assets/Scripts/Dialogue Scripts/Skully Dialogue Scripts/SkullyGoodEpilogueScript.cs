using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyGoodEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Askarios and I ended up finding out that we have a lot of common ground, and I was surprised to discover that I had fallen for him over the many, many years of being his servant.", "Skully"));
        var endText = new DialogData("/speed:0.03/At first, he thought to simply promote me to his majordomo, but after a lengthy romance, I eventually got my real promotion — husband.", "Skully");

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
