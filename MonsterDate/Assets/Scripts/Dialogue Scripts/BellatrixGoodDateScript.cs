using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class BellatrixGoodDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/[One week later]", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/I DO SAY, THAT FIRST ENCOUNTER WAS QUITE DELIGHTFUL, WOULD YOU NOT SAY, MINION? MY SPEECH ON THE INTRICACIES OF BONE FRACTURES SEEMED POSITIVELY ENTHRALLING TO HER!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/She seemed pretty into it, yeah. Think you might've made a good first impression, eh?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ANY IMPRESSION IS A GOOD ONE WHEN IT IS I IN QUESTION, MINION! I WOULD NOT SERVE AS THE RULER OF ZYX IF NOT FOR MY CHARISMA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Or, ya know... the fact that ya conquered them.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right... Anyway, I think we should see her again in a few days, huh? Keepin' up with her might make be the best to keep her attention. Can't just abandon your lovers, ya know?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERHAPS SO! WE SHALL SEEK HER MYRIAD GAZES ONCE MORE IN THE FUTURE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Hey, boss, think Bellatrix is out and about again. Looks like she's at the ice cream shop, hypin' herself up.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERFECT! WE SHALL ARRIVE THERE POSTHASTE, FOR I SHALL NOT SQUANDER THIS OPPORTUNITY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:askarios_cloak/[Askarios quickly dons his cloak, then rushes towards the hotel room's door.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/LET US GO, MINION! FORWARD!", "Askarios"));
        var endText = new DialogData("/speed:0.03/Right behind ya, boss.", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => LoadBellatrixGoodDatePt2();
    }
    #endregion

    void LoadBellatrixGoodDatePt2()
    {
        SceneManager.LoadScene("BellatrixGoodDatePt2");
    }
}
