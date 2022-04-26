using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MothmanBadDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, IS IT AN EFFECT OF GLIMMERROOT TO SO QUICKLY FALL UNCONSCIOUS?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I mean... it looked to me like Greg just kinda passed out on you.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AND HE IS A REGULAR SMOKER! 'TIS A SHOCK THAT I, THE VERITABLE NOVICE, HAD RESISTED SUCH URGES SO!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss... I think he just got bored.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WITH WHAT, MINION? OUR DISCUSSION WAS RATHER COMPELLING, NO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Compelling enough that he stopped listening, maybe.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I DO NOT INTEND TO BORE MY PARAMOURS! I HAD THOUGHT AN INTRICATE STATEMENT AS TO THE PHILOSOPHY BEHIND TORTURE, MAIMING, DISMEMBERMENT, AND MAGICKED UPHEAVAL WOULD BE RATHER ENTERTAINING TO ONE SUCH AS HE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well... even if that was the case, I don't think ya kept his interest. At least, not enough for him to stay with you.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HMM. I SHALL NEEDS IMPROVE THE DEPTH OF MINE BELIEFS TO A UNIQUE DEGREE, THEN! PERCHANCE HE HAD HEARD IT ALL ALREADY FROM ANOTHER SOURCE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Or, you know... he might just not care. But I'll let you do you.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SHALT RUMINATE ON SUCH WHILE I CHANCE MINE OWN REST! I CAN FEEL THE VAPORS ENTERING MY MIND AND SUBDUING MY CENTERS OF LOGIC!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(...No comment.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Two weeks later.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! PERCHANCE WE SHALT SEEK OUT GREGORY ONCE MORE! I SEEK HIS INSIGHT ON A MATTER SPAWNED FROM MINE OWN GLIMMERROOT - LADEN REFLECTION THIS PAST FORTNIGHT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Shit, not that...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, we could go look for him, if ya'd like. Pretty sure he left his location tracking on, so it wouldn't be too hard t—", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[There's a lazy knock at the door.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Heyyy, maaan... You in there?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/DEAR ME, WHAT FORTUITOUS TIMING!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(How did he...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios runs over and throws the door open with far too much force, nearly breaking the hinge in the process.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[On the other side of the door is Greg Mothman, standing amidst a cloud of glimmerroot smoke. Just like last time the two met, he has a martini in his free hand, while his other holds a large, lit joint.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/GREGORY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/'Eyyy, Askarios! How've ya been, maaan?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Without being invited, Greg lightly taps Askarios on the shoulder with his smoking hand, causing ashes to fall upon his robe, then walks into the hotel room, taking a seat on the bed.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Been a minute since we saw each other last, but I had to tell you somethin', and soon.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios turns, then retreats back into the room, idly wiping the residue off of his clothes. The smoke seems to be teasing his senses.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OH? PRAY TELL, FOR I HAD MINE OWN TOPICS TO DISCUSS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/And, uh... how'd ya find this room? Not like we told ya where it was, Greg.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oh... maaan, glimmerroot has some wacky effects, Bonesy. Shit made me feel like I had a connection with the big man here... and it kinda just guided me to him, like a call.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He chuckles, then lazily gestures around, emphasizing his point, punctuated with a long sip of his martini.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... my name's Skully.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Cool...", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully blinks.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Anyway, what'd you have to tell the boss?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Greg furrows his brow, appearing confused.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[After a moment of consideration, he perks up from the idea coming back to him, then gestures his joint towards Askarios, lightly tapping ashes onto the floor before taking an extended hit, which he exhales for just as long.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right... So, ya know how I said I was on vacation?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/INDEED SO, I DO! HATH SUCH PROCEEDED ACCORDINGLY TO THY PLANS?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Maaan, it's been great... but I'm almost due to go back home, ya know?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He coughs.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Thought I'd let ya know, maaan. I won't be around to romance you anymore, so I'm not sure if we should call it off before we get too far...", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NONSENSE! MINE COURTSHIP OF THEE HATH ONLY JUST BEGUN, AND THY PHILOSOPHY COULDST DRAW ZYX TOWARD A NEW BEGINNING, FILLED WITH PROSPERITY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IN FACT, I HADST WISHED TO DISCUSS SUCH TOPICS WITH THEE ON THIS DAY, BUT THOU HAST RETURNED TO MY SIDE BEFORE I HAD TO EVEN SEARCH! 'TIS A SIGN FROM THE HELLS ABOVE, I BELIEVE, THAT WE WERE MEANT FOR ONE ANOTHER'S ACCOMPANIMENT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You really think that, maaan? Shiiit, I thought it was just the smokin' that told me that.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He chuckles again.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/But yeah... I gotta go back to Point Pleasant soon, since I gotta keep up my appearances... Gotta make sure the 'victims' don't get too comfy, you know?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE! TORMENTING THE HARDLY INNOCENT MUST BE A CONSTANT, ELSE THEY GROW COMPLACENT AND PLEASED TO LIVE AS THEY DO! MY, GREGORY, THINE INSIGHT IS PALPABLE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Heh... been at it all my life, maaan, what can I say?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He smirks, then takes another hit.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/So... what do you wanna do, 'Skarios? Thought we hit it off pretty nice, huh? Might just wanna... keep it goin', then.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HMM... PERCHANCE I COULDST ATTEND THIS PLEASANTRY POINT WITH THEE ? OUR REIGN OF TERROR SHOULDST BE LEGENDARY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Honestly, maaan... I could see it. You, me, flyin' around and shit, bringing my omens and your realizations of them... Kinda perfect.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY, THAT SOUNDS UTTERLY DELIGHTFUL! WITH THE CRAFTING OF PROPER RUNIC SIGILS, I COULDST BRINGEST THEE TO ZYX AS WELL, THAT THOU MAYEST BRING THY TERROR TO IMPERIAL LANDS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Shiiit, maaan, I'll smoke to that.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He holds out the joint to Askarios, offering him to join in.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Come on, maaan. Let's talk about our plans... and whatever you wanted to discuss, too.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE, GREGORY! I SIMPLY WISHED TO ASK THEE HOW MY RULE MAY IMPROVE THROUGH ACTS THAT THOU WOULDST TAKE IN MINE POSITION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios takes the offer and huffs in an even longer hit than Greg had previously done. The smoke pours from the gaps in his bones and through his nasal cavity, making him look similar to a fog machine.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HELLS ABOVE, THAT IS STRONG... THOUGH NOT UNWELCOME, OF COURSE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[If he had the capacity to choke and gag, he would be coughing up a storm. Luckily, he doesn't have lungs, so that isn't the case.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Heh, yeah, maaan... I get it as pure as I can.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Greg leans back onto the bed, pressing his back against the mattress and gazing towards the ceiling, tracing out imaginary patterns on its distant painted surface with his finger.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Honestly, maaan... I ain't much of a ruler, but I do know how to make an omen+life balance... Might wanna start there, if I'm bein' real...", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios lays next to him, failing to envision whatever he's drawing in the air.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DO TELL MORE, GREGORY... MINE MIND HATH OPENED TO THE COSMOS... AND THEE AS WELL.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/'Course, course... Let's start with talkin' about your stress and work load, then, maaan...", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Hey, maybe Zyx will improve, huh? Eh...who am I kiddin', it's gonna get worse.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Probably much worse. Honestly, that's maybe for the best at this point.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[For what could be hours upon hours, Greg and Askarios appear to have their discussion, with Skully failing to follow for a vast majority of it.]", "Narrator"));
        var endText = new DialogData("/speed:0.03/[Multiple joints and martinis later, they both managed to pass out at similar time frames, slightly wrapped up in one another's arms. What information was garnered from that conversation is up to anyone's interpretation.]", "Narrator");

        endText.Callback = () => LoadMothmanMatch3Pt2();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadMothmanMatch3Pt2()
    {
        SceneManager.LoadScene("MothManBadNeutralPuzzle");
    }
}
