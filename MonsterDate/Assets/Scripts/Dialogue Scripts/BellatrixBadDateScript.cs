using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class BellatrixBadDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/[One week later]", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/WELL, I DO BELIEVE THAT SHE ENJOYED OUR CONVERSATION, HMM, MINION? HER MANY EYES WERE FOCUSED ON ME FOR SO VERY LONG, SO I AM ALL BUT CERTAIN OF HER ENTHRALLMENT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Eh... Boss, I think ya might've been boring her. You really sure she was lookin' at you? Compound eyes can be focused anywhere, not just on where it looks like she's lookin'.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHAT SPOKE TO HER ALLEGED DISINTEREST? HER ATTENTION WAS TRAINED ON ME, AND SHE CONTINUALLY SMOOTHED HER CLOTHING TO BETTER HOLD HER APPEARANCE FOR MY GAZE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/That's... kinda somethin' people do when they don't wanna listen anymore, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OH.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WELL, I DO HOPE THAT I WAS NOT A BLIGHT UPON HER DAY, GIVEN THAT I WAS INFORMING HER OF QUITE A LOT OF PERSONALIZED INFORMATION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Guess we'll have to see when we see her next, huh? Don't think she hates ya, but ya might need to try a little harder next time to make her happy.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WE SHALL SEE IN THE FUTURE, THEN, MINION! I SHALL STUDY THE ART OF CONVERSATION ONCE MORE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right... Yeah, maybe ya should, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Hey, boss, think Bellatrix is out and about again. Looks like she's at the ice cream shop, hypin' herself up.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERFECT! WE SHALL ARRIVE THERE POSTHASTE, FOR I SHALL NOT SQUANDER THIS OPPORTUNITY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:askarios_cloak/[Askarios quickly dons his cloak, then rushes towards the hotel room's door.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/LET US GO, MINION! FORWARD!", "Askarios"));
        var endText = new DialogData("/speed:0.03/Right behind ya, boss.", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => LoadBellatrixBadDatePt2();
    }

    void LoadBellatrixBadDatePt2()
    {
        SceneManager.LoadScene("BellatrixBadDatePt2");
    }
}
