using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class BellatrixGoodDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    public GameObject hotel;
    public GameObject icecream;

    void Start()
    {
        GoodDateStart();
    }

    #region Dialogue Start
    public void GoodDateStart()
    {
        hotel.SetActive(true);
        icecream.SetActive(false);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/I DO SAY, THAT FIRST ENCOUNTER WAS QUITE DELIGHTFUL, WOULD YOU NOT SAY, MINION? MY SPEECH ON THE INTRICACIES OF BONE FRACTURES SEEMED POSITIVELY ENTHRALLING TO HER!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Thumbsup1/She seemed pretty into it, yeah. Think you might've made a good first impression, eh?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ANY IMPRESSION IS A GOOD ONE WHEN IT IS I IN QUESTION, MINION! I WOULD NOT SERVE AS THE RULER OF ZYX IF NOT FOR MY CHARISMA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Or, ya know... the fact that ya conquered them.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right... Anyway, I think we should see her again in a few days, huh? Keepin' up with her might make be the best to keep her attention. Can't just abandon your lovers, ya know?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERHAPS SO! WE SHALL SEEK HER MYRIAD GAZES ONCE MORE IN THE FUTURE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[One week later]", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Hey, boss, think Bellatrix is out and about again. Looks like she's at the ice cream shop, hypin' herself up.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERFECT! WE SHALL ARRIVE THERE POSTHASTE, FOR I SHALL NOT SQUANDER THIS OPPORTUNITY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:askarios_cloak/[Askarios quickly dons his cloak, then rushes towards the hotel room's door.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/LET US GO, MINION! FORWARD!", "Askarios"));
        var endText = new DialogData("/speed:0.03//emote:Thumbsup2/Right behind ya, boss.", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => GoodDateContinue();
    }
    #endregion

    #region Dialogue Continue
    public void GoodDateContinue()
    {
        hotel.SetActive(false);
        icecream.SetActive(true);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/[The two head over to the Ice Cream Shop.]", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IT HAS BEEN QUITE THE TIME SINCE I INDULGED IN THE SACCHARINE SWEETNESS OF ICED CREAM! SURELY THE CULTURE HAS NOT SHIFTED IN THE CENTURIES SINCE I WAS BUT A CHILD!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, it might've, but... ice cream is ice cream, boss. Shit doesn't really change much.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THEN I SHALL NOT BE CAUGHT OFF GUARD BY MY EXPECTATIONS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Askarios?! Man, it's been a long week, huh?", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[From the counter approaches Bellatrix, holding a tall waffle cone with four rainbow-colored scoops precariously stacked atop it.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/How've you been? The tour going well? Must be pretty expensive to stay in Paleon City for this long.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The sugar rush in her is palpable.]", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY 'TOUR' HAS PROCEEDED DELIGHTFULLY, BELLATRIX, FOR I HAVE MET THEE UPON IT! IT IS WITH GREAT FORTUNE THAT WE HAVE MET AGAIN ON THIS DAY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/[Bellatrix blinks at the compliment, then lightly blushes.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Glad to hear it, man! Glad to hear it.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She perks up, suddenly remembering something.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oh! Right, I wanted to tell you — your knowledge was suuuuper helpful. I put together a whole new song from the inspo you gave me, and I'm gonna be performing it at our show tonight.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She winks her innumerable lenses.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Bit of a surprise for our fans. They get to hear a new song firsthand!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THINE PASSION IS APPARENT, BELLATRIX! PRAY, TELL ME OF YOUR CONCERT, FOR I AM UNFORTUNATELY UNAWARE OF SUCH AN EVENT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Ooh, right, right. So, we're gonna be performing at the Dark Sun Revelry tonight! They set up a stage at the beach, and we're gonna be going on at midnight.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She pumps her fist in excitement.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I'm soooo hyped! We haven't had a show in MONTHS, so this is just exhilarating!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SEE... WOULDST THOU BE OFFENDED IF I WERE TO ATTEND?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Not at all, man! The more people, the better! Hope ya don't mind getting put in the pit, though!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She gently punches Askarios on the arm, letting out a chuckle.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THINE BARDIC SHOWCASES POSSESS A PIT OF TORTURE? SUCH A DISPLAY OF CULTURE! THE BLACK RAVINES OF ZYX WERE SUCH DELIGHTFUL LOCALES TO DISPOSE OF THE DAMNED!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss... I don't think that experience is universal.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Bellatrix swallows down the remains of a scoop, then blinks at Askarios's assessment.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... Nah, just the mosh pit. You know, where people slam into each other when they dance?", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/A PLACE OF COMBATIVE ENTERTAINMENT? MY, I DID NOT THINK SUCH PERFORMANCES WOULD BRING FORTH GLADITORIAL COMBAT AS WELL!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... Sure! Let's go with that! People do get pretty fucked up in there, so...", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Ooh, wait. Let me give you one of these, then!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:bella_pocketbadge/[She reaches into her pocket, then pulls out a lanyard with a pass hooked upon it, which she hands over to Askarios. On it, it reads 'Backstage VIP'.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Wear that to the show, and they'll let you in the back when everyone's done! There's usually a meet-and-greet after the show, so we can talk more there!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/BUT WE HAVE ALREADY MET AND GREETED, NO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, yeah, but that's where people usually talk to the stars of the show. Might have some weirdos come in, so I think you could easily intimidate them away from me.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/INTIMIDATION IS A SPECIALTY OF MINE, AS IT WERE! THEY SHALL QUAKE IN FEAR AT MY VERY PRESENCE, AS THEY ONCE DID IN SKENTIRA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Perfect! I don't have the cash to hire a bodyguard, so you'll do. Guess we call it a date, huh?", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She smiles, then holds out her hand to give Askarios a handshake of confirmation.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE, YES! WE MAY CALL IT A NIGHT OF ROMANCE AND DEBAUCHERY! I SHALL BRING MY BEST BEACH ATTIRE, FOR THE SANDS DO NOT PLEASINGLY COAT MY ROBES!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sounds great!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Bellatrix nods, then looks at her phone to check the time.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I gotta go, but I'll see you there! Hope you enjoy yourself, man!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SHALL VISIT THEE ANON! DO TAKE CARE IN THINE PERFORMANCE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:bella_woodsteps_runaway/[Askarios waves to Bellatrix as she runs out of the store, scarfing down her unfinished ice cream along the way.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WELL, MINION, I DO SAY THAT MY SECOND DATE IS SECURED, NO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Thumbsup2/Surprisingly, yes. That looks to be the case, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ONWARD, THEN, MINION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:askarios_woodsteps_away/[Without so much as thinking of buying any ice cream, Askarios leaves the store.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Sad/Let me... Get a smoothie. This shit's gonna give me a headache — I know it.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Sad/[Skully turns to the employee, who has completely ignored everything that happened in the past few minutes.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Hey, boss man, gimme a Strawberry Storm. Put some of that caffeine shit in it too.", "Skully"));
        var endText = new DialogData("/speed:0.03/Sure thing, sir.", "NPC");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => LoadBellatrixMatch3Pt2();
    }
    #endregion

    void LoadBellatrixMatch3Pt2()
    {
        SceneManager.LoadScene("BugGirlPuzzleGoodNeutral");
    }
}
