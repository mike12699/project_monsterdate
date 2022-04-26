using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MyraDateStart : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/AN ICED CREAM CONFECTIONARY?! MY, I HAVE NOT INDULGED IN SUCH SWEETS SINCE I WAS BUT A CHILD!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/So... centuries ago?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/YES! BUT I CAN STILL TASTE THE SWEET CREAM UPON MY NECROTIZED TONGUE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Gotcha... Well, anyway, it looks like your date should be here. At least, that's what my research told me...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WELL, WHILE WE SEEK SUCH A PARAMOUR, I SHALL ORDER MYSELF A DESSERT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HARK, SCOOPING SERVANT! I SHALL HA— GAH! WHAT IS THIS SUBSTANCE I HAVE STEPPED UPON?!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/H-hey, p-please watch where you're g-going...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Casting his gaze down, Askarios beholds a translucent pile of slime, formed into the shape of a young woman. Unfortunately, it appears as if part of her has splattered onto his boot.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AN OOZE! FORFEND THYSELF FROM EATING THROUGH THE LEATHERS OF MY CLOTHING, ELSE I SHALL NEED TO SPEAK TO THE LORD OF THY CREATION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Crying/S-sorry...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Crying/[She sniffs, as if about to cry, then reaches forward to scoop the bits of her body from Askarios's shoes back into her form.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Psst... boss, be nice to her. /wait:0.5/I noted that she's easy to scare, and I'm completely certain that you absolutely read that.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/DEAR ME, DO NOT WORRY! CONTINUE YOUR ORDER — I SHALL AWAIT THY COMPLETION.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/U-uhm... /wait:0.5/ok...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She slides herself over to the counter and rolls her body up its side, allowing herself to face the cashier, who has since resigned to glance at their phone.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/A scoop of m-mint chocolate chip on a sugar cone, p-please.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SUCH A DELIGHTFUL FLAVOR YOU HAVE CHOSEN! PRAY, TELL ME THY NAME, THAT WE MAY CONVERSE MORE OPENLY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/U-uhm... /wait:0.5/I'm... M-Myra.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/GOOD GREETINGS, MYRA! I AM ASKARIOS — LICH LORD OF SKENTIRA, TYRANT OF ZYX, AND MASTER OF UNDEATH.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/T-that's a lot of words... /wait:0.5/Uhm...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She offers a shy wave of an arm stub.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/N-nice to meet you, Askarios.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The employee soon returns with her ice cream, which Myra lodges inside of what could be called her hand.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PRAY, SERVANT, PROVIDE ME WITH YOUR FINEST DOUBLE NIGHTBERRY MOONRISE, IF YOU COULD.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[They blink at Askarios in confusion, but soon shrug and walk back to the cooler. They aren't paid enough to really care all that much.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/TELL ME OF THEE, MYRA! WHAT DRAWS THEE TO SUCH A FINE ESTABLISHMENT ON THIS DAY?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I w-wanted ice cream... /wait:0.5/I'm r-rewarding myself for g-getting through my f-finals.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AH, A UNIVERSITY STUDENT! 'TIS ADMIRABLE TO PURSUE HIGHER KNOWLEDGE. PRAY TELL, WHAT IS THY STUDY? ARCANUM? MEDICINAL STUDIES OF THE FOUR HUMOURS?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I-I'm... /wait:0.5/an artist. /wait:0.5/P-painting, mostly.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THE PURSUIT OF CREATIVITY! LONG HAS IT BEEN SINCE I MET ANOTHER OF YOUR CRAFT.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/U-uhm... /wait:0.5/Th-thanks?", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She takes a bite out of her scoop of ice cream, which is clearly visible through her body. Interestingly enough, it seems to dissolve as it enters where her 'stomach' would be.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/D-do you study anything?", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IN AGES PAST, I STUDIED THE ART OF NECROMANCY, TO WHICH I AM A MASTER!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/T-that's scary... /wait:0.5/But c-cool, I guess...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Crying/[She looks like she's about to cry again.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PRAY TELL, WHY ARE YOU SO VERY COY? DOES MY APPEARANCE FRIGHTEN THEE?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Crying/N-no... /wait:0.5/I'm just... /wait:0.5/a nervous person, I g-guess. /wait:0.5/Sorry...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She sniffs, then lets out a stuttered breath. Globs of ooze begin to run down her face, quickly absorbing back into her body as they reach her chin.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DO NOT SUCCUMB TO TEARS, MYRA! TELL ME, HOW ART THINE EXAMS PROCEEDING? I RECALL THE DIFFICULTY OF PLEASING MY SUPERIORS, TO WHICH THEY SOON KNEW MY WRATH, GIVEN THAT THEY QUICKLY BECAME MY SUBJECTS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/T-they're... /wait:0.5/going ok, I guess... /wait:0.5/I'm just... /wait:0.5/not ready for my last one...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/WHY IS THAT?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/We have to... /wait:0.5/do something that c-clashes with our normal style... /wait:0.5/I usually p-paint cute things...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/I SEE...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[After a moment of thinking, Askarios perks up, coming upon an idea.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I POSIT SUCH: PAINT A PORTRAIT OF THE LORD OF DEATH BEFORE THEE — A TESTAMENT TO MY POWER AND AN IMAGE OF TYRANNY FOR THINE PORTFOLIO!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/U-uhm... /wait:0.5/Are you s-sure? /wait:0.5/Painting takes a while... /wait:0.5/You might need to p-pose for hours...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I HOLD NO DISDAIN FOR SUCH, MYRA! A STILLNESS, I MAY HOLD, FOR MY BONES HAVE LONG SINCE GROWN PAST STIFFNESS! PERCHANCE THOU WOULD EVEN NEEDS BEHOLD MY NUDE FORM, SHOULD THOU REQUIRE IT.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The employee side-eyes Askarios, then returns to working on his order.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/[Myra waves her arms in front of her, dismissing the thought.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/T-that w-won't be necessary, sorry!", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Here you are, sir. Whatever you ordered.", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The employee places an improvised, sundae-like mass upon the counter. It appears to be two scoops of rocky road ice cream with blackberries, fudge drizzle, and toffee precariously lodged upon the surface.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SUCH A REGIONAL VARIATION! I SHALL JUDGE THINE CRAFT IN COMPARISON TO THAT OF SKENTIRA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The employee shrugs.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Whatever, sir. Enjoy.", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MYRA! PERCHANCE WE SHALL INDULGE IN OUR DESSERTS YONDER? I DO BELIEVE A DISCUSSION OF ART AND OUR ACCOMPLISHMENTS IS IN ORDER!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/U-uhm... /wait:0.5/I guess. /wait:0.5/L-let's go...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Myra slides over to a nearby table, rolling herself up to 'sit' upon the chair. Askarios follows, towering over her as he takes his own seat.]", "Myra"));
        var endText = new DialogData("/speed:0.03/Uh... alright. Guess we can call that a date, huh? You do you, boss.", "Skully");

        endText.Callback = () => LoadMyraMatch3();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadMyraMatch3()
    {
        SceneManager.LoadScene("SlimeGirlPuzzle");
    }
}
