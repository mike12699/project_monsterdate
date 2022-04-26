using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class EyevanNeutralEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/During his education in necromancy, Eyevan found that he cared more for the art than his mentor, and his studies grew ever the more intensive on perfecting his newfound craft.", "Skully"));
        var endText = new DialogData("/speed:0.03/In time, he became a master necromancer, but his journey took him elsewhere — to dominate on the continent of Paleon City.", "Skully");

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
