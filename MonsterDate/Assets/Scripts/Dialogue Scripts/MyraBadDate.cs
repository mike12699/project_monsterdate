using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MyraBadDate : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, I COULD SPOT HOW SHE QUIVERED IN MY PRESENCE! HOW DELIGHTFUL SHE MUST HAVE FELT INTERNALLY TO HAVE REACTED IN SUCH A MANNER.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss, I think she was bordering on panic the whole time.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHAT WOULDST MAKE YOU OBSERVE SUCH, MINION? MANY TREMBLE AT MY VERY PERFECTION — MY PRESENCE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I could just... tell, boss. Her body was gettin' unstable with every shake.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/...OH.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WELL, I DO BELIEVE HER PAINTED STROKES REMAINED PRECISE EITHER WAY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Even so, that... /wait:0.5/doesn't really mean much for your relationship.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WE SHALL SEE UPON OUR NEXT MEETING, THEN! I EAGERLY AWAIT THE TIME IN WHICH SHE SHALL CONTACT ME ONCE MORE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Assuming she does at all...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Two weeks later.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios's date-seeking app buzzes with a series of notifications.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/GAH! MINION, THIS DEVICE IS...VIBRATING! PRAY, WHAT ELEMENTAL FORCE HATH POSSESSED IT?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss, that's... Just open the fuckin' app.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios blinks, then struggles to unlock the phone. The capacitive touch screen doesn't easily react to his bony fingers.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/DAMNED THING!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[After a few minutes of poorly-made attempts, some infused with minor cantrips and spells of ridiculous power, he eventually manages to get the app open.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Upon the screen, the following text is displayed:]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SuraimuSuraimu: ASKARIOS! Uhm, sorry, I mean... Anyway. Uhm, can you come meet me at the market? I wanna... update you on... my art test. Uhm... Yeah, just meet me!!!1!", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! I BELIEVE ANOTHER PARAMOUR HAS CONTACTED ME!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss, that's...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully pinches the bridge of where his nose used to be.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/That's Myra.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SUCCESS, THEN! SHE HAS FOUND THE NEED TO DATE ME ONCE AGAIN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Let's not be hasty now, boss. She might just wanna meet up with ya.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ONWARD, MINION! TO THE MARKET!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully sighs.]", "Skully"));
        var endText = new DialogData("/speed:0.03/Right... Let's go.", "Skully");

        endText.Callback = () => LoadMyraDatePt2();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadMyraDatePt2()
    {
        SceneManager.LoadScene("MyraDatePt2");
    }
}
