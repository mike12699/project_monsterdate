using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyDateEndScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/BEHOLD, SKULLY — THE BEAUTY OF THE NIGHT SKY UPON A ROLLING CLIFFSIDE AND THE DISTANT, CLEAR SIGHT OF THIS WORLD'S MOON!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Did he... /wait:0.5/take me to a cemetery?)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ART THOU IMPRESSED? 'TIS QUITE THE ENCHANTING ATMOSPHERE, IS IT NOT?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(It is... /wait:0.5/kinda pretty, I'm not gonna lie.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... Yeah, Askarios, it sure is.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Just... /wait:0.5/maybe a little poor in taste.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios claps his hands together, echoing the clacking of his bones through the silence of the surrounding area.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AM GLAD, SKULLY! PRAY, COME WITH ME TO THE BENCHES, AND WE SHALL ENJOY THE SIGHTS TOGETHER, NO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Sure. Yeah, sure, sure.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios makes his way over to a nearby wrought iron bench, where he plants himself down. Skully soon follows, his shoulders held forward in slight awkwardness, and quietly takes a seat.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I THOUGHT THIS LOCALE WOULD SUIT THEE WELL, SKULLY! I AM QUITE FOND OF LICHYARDS, GIVEN MY CRAFT, AND I THOUGHT TO SHARE SUCH ADORATION WITH MY POTENTIAL PARAMOUR!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/It's... /wait:0.5/nice, boss. Real nice.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(The moon is gorgeous and all, but...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully wrings his hands, then sighs.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios tilts his head and quirks a questioning brow.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/ERM... SKULLY? IS AUGHT AMISS?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Huh?!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully snaps to attention, then ceases all action to focus on Askarios's gaze, which has become trained on him.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oh, uh... No, no, nothing's wrong.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Sorry. Don't wanna ruin the mood.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He lets out an awkward chuckle.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, DO TELL WHAT TROUBLES THEE — I COMMAND IT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[If Skully could bite his lip, he would. Unfortunately for him, he can't, so he settles for wrapping his fingers on the irons of the bench.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/It's pretty and all, boss, but... /wait:0.5/It just gives me bad memories, that's all.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/HOW SO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, like I said at our dinner date, ya just kinda raised me from the dead without my consent.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I'll... never really get to see what the afterlife is like because of that, and my soul was torn from ever getting to see my family again.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/We... kinda just lived in fear of starvation and massacre, seeing how your army liked to stage its conquest, so... /wait:0.5/yeah.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Thought I'd be free from all that when the life had finally left my body. Guess not, though.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/So, when you brought me back, I didn't go straight to your service — I'm sure ya remember that.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I was left to wander around and see how the world had changed after the slaughter, and I spent quite a bit of time mourning the remains of my parents and sisters.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/I SEE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/[Askarios clears his throat, then hesitantly places his hand on Skully's shoulder, as if to comfort him.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I... FEEL AS IF I MUST APOLOGIZE, SKULLY. NEVER DOES IT CROSS MY MIND TO CONSIDER THE THOUGHTS OF MY SERVANTS.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Clearly)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I COULD BRING THINE PARENTS TO LIFE, IF THOU WOULDST WISH IT... OR I COULD REMOVE THEE FROM MY SERVICE, EVEN IF THOU ART QUITE THE HIGHEST OF BOONS TO MY RULE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/No. Leave 'em, Askarios.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully slaps Askarios's hand off of his shoulder and scoots away from him, pulling up his knees in a gesture of self comfort.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I don't want 'em back. They wouldn't recognize me anymore, and I don't want 'em ripped from the Heavens too.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/It's too late to be makin' changes to what happened. I've learned to cope, and I've dealt with it all on my own for decades now.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Just... leave it alone.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/[Askarios places his hand on his lap in embarassment.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Five minutes of silence ensue.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Another five minutes follow, broken only by the rustling of leaves in the breeze.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Where it would seem that even more silence would occur, it is finally shattered by Skully beginning to lightly sob.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Man, fuck.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/SKULLY...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/This is all your doing, Askarios. I hope you fuckin' know that.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/[Askarios sucks in a breath, then lets it out.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...I DO NOT KNOW TO WHAT EXTENT OF APOLOGY I COULD STATE TO COMFORT THEE, SKULLY. 'TIS EVIDENT THAT MINE ACTIONS OF THE PAST WERE SELFISH, AND I ACKNOWLEDGE SUCH.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NO MATTER THE CASE, I WOULD OFFER TO MAKE YOUR CURRENT UNDEATH OF HEAVENLY QUALITY, THAT YOU MAY ENJOY AN AFTERLIFE IN UNLIFE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AND TO THAT, I MUST OFFER MY DEEPEST OF APOLOGIES. KNOW THAT THOU ART MY MOST CHERISHED OF ALLIES, AND MY RULE WOULD BE WEAKENED WITHOUT THEE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Another minute of awkward silence follows, but Skully soon breaks it by bringing his gaze to Askarios once more.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Be honest, Askarios. Do you really WANT to be my partner?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I've always felt like you've seen me as nothin' more than a servant, and it's hard to feel appreciated when you're just bein' ordered around and called by terms of suboordination.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/TO THE DEEPEST RECESSES OF MY BLACKENED SOUL, SKULLY, I AM HONEST WITH THEE. YOU HAVE A WISE SPIRIT WITHIN YOUR HANDSOME SHELL, AND I BELIEVE OUR COMPATIBILITY TO BE GREATER THAN THAT OF MOST OTHER PARAMOURS UPON THIS WORLD'S SOIL.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/BUT PERCHANCE WE SHOULD... BEGIN OUR RELATIONSHIP ANEW, THEN, NO? I WOULD NOT PRESUME THAT CONTINUATION UPON OUR CURRENT PATH WOULD LEAD TO PROPER ROMANCE OR LOVE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully wipes his lack of tears away from his face and unfurls his body, bringing himself back to Askarios's side.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Yeah, let's... just start over, Askarios. It's... probably for the best, honestly.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully rubs the back of his neck with an awkward chuckle, then places his other hand upon Askarios's lap.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios smiles, then wraps his arm around Skully's neck.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THE MOON IS QUITE BEAUTIFUL, IS IT NOT, SKULLY?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully lets out a content sigh, then leans onto Askarios, closing his eyes.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/It sure is, Askarios. It sure is.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[With his own happy chuckle, Askarios closes his eyes as well, simply enjoying the moment.]", "Askarios"));
        var endText = new DialogData("/speed:0.03/AND THAT IS ALL I COULD ASK FOR ON THIS EVE.", "Askarios");

        endText.Callback = () => LoadSkullyMatch3Pt2();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadSkullyMatch3Pt2()
    {
        SceneManager.LoadScene("SkullyPuzzlePt2");
    }
}
