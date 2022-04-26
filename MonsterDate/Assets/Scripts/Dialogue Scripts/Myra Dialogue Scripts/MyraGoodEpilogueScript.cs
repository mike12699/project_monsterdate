using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MyraGoodEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Myra discovered that she had a bit of a freaky side to her, and that Askarios filled in that little hole in her life pretty well.", "Skully"));
        var endText = new DialogData("/speed:0.03/After graduating from university with straight A’s, she took the lich on innumerable dates (preferring to keep it slow), and eventually they came to live the calm lives of artists together, with Askarios only somewhat humbling himself in the process.", "Skully");

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
