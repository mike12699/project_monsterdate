using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyDateStartScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    public GameObject market;
    public GameObject dinner;

    void Start()
    {
        DateStart();
    }

    #region Dialogue Start
    public void DateStart()
    {
        market.SetActive(true);
        dinner.SetActive(false);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! I HAVE MADE MY DECISION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Alright, boss, who's it gonna be? Eyevan? Bellatrix? Greg Mothman?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHILE THE VARIETY OF CHOICE YOU PRESENT IS ADMIRABLE, I FIND THAT I HAVE BEEN STARING MY PARAMOUR STRAIGHT IN THE EYE SOCKETS FOR QUITE SOME TIME NOW!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Ya did take a while to choose, so... Which pic caught your fancy?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY CHOICE OF DELCARATION IS...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios points to Skully.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...THEE, MINION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Alright, let's get goin', the— /wait:0.5/Wait, huh?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THE PROSPECTS OF ROMANCE ARE NOT LOST ON THOU, ARE THEY? I HAVE MADE MY DECREE, AND WE SHALL PURSUE OUR DATE POSTHASTE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh...Boss, you sure about that? I put in all that work to search for singles in our area for a reason.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION... LONG HAVE I YEARNED FOR THE TOUCH OF ONE THAT I HOLD DEAR, AND WHO IS MORE FAMILIAR TO ME THAN THEE?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[If Skully could blink, he would.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... Whatever you want, boss, I guess. I'll humor ya.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Where are ya takin' me, then?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I WOULD POSIT A DINNER BY CANDLELIGHT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/How cliché.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NOW, ARE YOU AWARE OF ONE SUCH LOCALE, GIVEN YOUR RESEARCH? I SHALL ASSUME YOUR SEARCH HAD REVEALED AT LEAST ONE SHOP OF THE FEASTING VARIETY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You know, usually the restaurant is chosen by the person wanting the date, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AND MY DECISION IS THE EATERY OF YOUR SPECIFICATIONS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully sighs.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Fair enough, I guess.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/EVEN SHOULD YOU NOT RECIPROCATE MY LOVE, IT SHALL BE SUITABLE PAYMENT FOR THINE PAST SERVICES!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/How kind of you, boss. You've never paid me at all before this.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY GENEROSITY IS BOUNDLESS TO MY SERVANTS!", "Askarios"));
        var endText = new DialogData("/speed:0.03/Yeah, yeah, let's just... get this over with, boss.", "Skully");

        endText.Callback = () => DateContinue();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    #region Dialogue Continue
    public void DateContinue()
    {
        market.SetActive(false);
        dinner.SetActive(true);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/SERVANT! A TABLE FOR MY MINION AND I!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[After a moment of waiting, Askarios and Skully are brought to a neatly set table, soon populated by a basket of complimentary bread and glasses of dark red wine.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Nice place, huh, boss? Looked like some fancy food, wine, that kinda shit.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IT IS AESTHETICALLY PLEASING, MINION!LET US HOPE THAT ITS QUALITY SATISFIES MY PARTICULAR TASTES OF CUISINE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Do you... even have taste buds anymore?)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You know, boss, you should probably call me by my name if we're going to be...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He pauses, then sighs once more.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...partners.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE! THAT WOULD ONLY BE PROPER, MINION! LET ME SEE... YOUR NAME IS...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios thinks hard on that question for a moment. Visually, he's struggling.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/UHM... HMM... WELL... I DO BELIEVE IT IS...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/BONESY! NO, SKULLSWORTH! RIGOR MORTIS! YES, THAT SOUNDS CORRECT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Skully, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SKULLY! YES, THAT IS YOUR NAME! THAT WAS MY NEXT GUESS.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Yeah. Anyway, boss, I think I should give you the same treatment.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/So, for the duration of our romance, I'll be callin' ya by your name.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He smirks his best lipless smirk.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Got that... /wait:0.5/Askarios?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios scoffs.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/HOW IMPROPER! I AM YOUR LORD — YOUR MASTER! I RAISED YOU FROM THE DEAD! THE RESPECT I DESERVE IS NOT GIVEN BY SUCH BLUNT TITLES!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/And what kind of relationship would we have if not for a lack of a power dynamic, huh?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...FAIR ENOUGH.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Hey, waiter! Get me some spaghetti. I'm starvin' here.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I DESIRE YOUR SHEPHERD'S PIE! LONG HAS IT BEEN SINCE I HAVE SEEN A LAMB, AND MUCH LONGER HAVING DEVOURED ONE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[After the order is logged, Skully turns to once again look at Askarios.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You know, Askarios, I didn't ask to be made into your minion. Any reason ya chose me over... literally any other skeleton in the death yards?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NECROMANCY IS QUITE DIFFICULT WHEN BONES ARE HEAVILY FRACTURED, AND SOMEONE TOOK CARE TO NOT DESECRATE YOUR BODY PRIOR TO YOUR DEATH.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/AND, IF I AM BEING HONEST — YOUR BONES WERE RATHER DASHING TO THE EYE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You... /wait:0.5/thought my bones were... /wait:0.5/hot?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AM A LORD OF UNDEATH, SKULLY! THE DEAD CAN BE JUST AS ATTRACTIVE AS THE LIVING TO MY NECROTIC SIGHT.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[There is a long, awkward pause out of Skully.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right... You know, the living would find that a bit creepy, honestly.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/And here I was thinkin' that ya chose me because I looked like I'd be a good advisor.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/STRONG BONES LEAD TO STRONG FOUNDATIONS, BOTH IN BODY AND MIND! I SHALL ASSUME YOU DRANK QUITE THE ASSORTMENT OF DAIRY IN YOUR LIVING YEARS.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I was lactose intolerant.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/OH.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WELL, THEN I SUPPOSE THAT YOU SIMPLY TOOK CARE OF YOURSELF. SUCH IS THE SIGN OF INTELLIGENCE AND GRIT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WOULD THAT MY OWN BONES WERE REINFORCED IN SUCH A MANNER! ONLY THEN WOULD MY RULE HAVE BEEN EVER THE MORE OPPRESSIVE TO MY ENEMIES!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, count me flattered, Askarios.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios takes a moment to sip from his glass of wine, though the drink is quick to stain the seat as it falls through his bone cavities.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DO YOU ENJOY SERVING ME, SKULLY?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully stares for a moment, then snaps back to attention.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Eh... It's iffy, if I'm being honest. Nice not havin' to live in fear, like I had in my living days, but...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He lets out a nervous chuckle.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Kinda wish I was allowed to see the afterlife. Heard all about it in my time as a mortal — the eternal reward of the gods, given to the living in death. Sounded like a paradise compared to what I was goin' through.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SHALL MAKE OUR RULE ONE OF GREAT PLEASURE, THEN, SKULLY! OUR DOMINION SHALL BE LEGENDARY, RIVALING EVEN THE DIVINE IN STATUS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Pretty grand plan, Askarios. Think we should make sure this whole date thing works out first.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AGREED! WE SHALL NOT DEDICATE TO SCATTERING THE WIND WITH DEATH AND ENTRAILS SO SOON!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Proooobably for the best.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[A few minutes later, the waiter returns with the pair's food. For Skully, a heaping plate of fettuccine Alfredo, and for Askarios, a deep shepherd's pie.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/AH, SUCH SMELLS! QUITE DELIGHTFUL!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Not even taking a minute to think, Skully has already dug in.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY, SUCH QUICK DECISION MAKING! A RULER IN THE MAKING ALREADY, I SEE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/BUT LET US EAT AND DISCUSS AS WE SEE FIT!", "Askarios"));
        var endText = new DialogData("/speed:0.03/[Slurping up some noodles, Skully nods, then quickly returns his focus to bringing more of the pasta to his mouth.]", "Skully");

        endText.Callback = () => LoadSkullyMatch3();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadSkullyMatch3()
    {
        SceneManager.LoadScene("SkullyPuzzle");
    }
}
