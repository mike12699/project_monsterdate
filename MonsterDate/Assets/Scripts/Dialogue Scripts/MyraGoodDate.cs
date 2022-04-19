using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MyraGoodDate : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, I DO BELIEVE HER INTEREST IN PAINTING THE INNUMERABLE INTRICACIES OF MY CHEST CAVITY WAS ENLIGHTENING TO HER INTEREST IN ME, NO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, can't say ya seemed to have scared her, boss. Thinkin' that's... probably a good thing.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HER NERVOUS NATURE SEEMED TO HAVE QUELLED IN MY PRESENCE! I WOULD POSIT SUCH AS A PERSONAL VICTORY.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/She sure focused more, that's true. Ya think ya made a good impression?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I CAN ONLY ASSUME HER LINGERING GAZE UPON MY NETHERS DISPLAYED HER PIQUED ADORATION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Eh, I guess s— Wait, where was she lookin'?!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IN OUR PRIVATE MOMENTS, SHE ASKED I STRIP FOR THE BETTERMENT OF HER ARTWORK!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oh...Well, alright.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Let me pray she was just tryin' to get the details right.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NEVERTHELESS, WE SHALL REST! THERE ARE STILL YET ROMANTIC PURSUITS TO...PURSUE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Yeah...Leeeeeet's get on that, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Don't think too hard about what she saw, don't think too hard about what she saw, don't—.)", "Skully"));
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
        dialogueTexts.Add(new DialogData("/speed:0.03/That's Myra.",  "Skully"));
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
