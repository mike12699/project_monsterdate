using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class EyevanBadEpilogueScript : MonoBehaviour
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

        dialogueTexts.Add(new DialogData("/speed:0.03/Eyevan continued to use Askarios for his own benefit, taking every lesson in necromancy that he was offered as another opportunity to increase his level of power. After declaring himself a master necromancer, he vanished into the night, never to return to the lich’s citadel.", "Skully"));
        var endText = new DialogData("/speed:0.03/In the coming months, an army of death and blood encroached on the horizon of Zyx, led by none other than Eyevan himself, with the soldiers bearing a familiar mark — the crest of Skentira", "Skully");

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
