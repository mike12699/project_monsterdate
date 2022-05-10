using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class IntroSceneScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    public GameObject citadel;
    public GameObject market;
    public GameObject canvas;

    void Start()
    {
        IntroStart();
    }

    #region Dialogue Start
    public void IntroStart()
    {
        canvas.SetActive(true);
        citadel.SetActive(true);
        market.SetActive(false);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/ZYX -- AN EMPIRE WITHOUT BORDER... AN EMPIRE OF GHOSTS.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/LONG HAD IT STOOD AT THE FAR REACHES OF THE REGION OF KAZ, ITS DIABOLIC CITADELS AND TOWERING OBSIDIAN STRUCTURES PLAGUING THE NATURAL BEAUTY OF THE LAND, STANDING AS EDIFICES OF DEATH AND SUBJUGATION.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/FOR CENTURIES DID ITS REACH EXPAND, ITS ARMIES OF UNDEATH CASTING THE LIVING TO ETERNAL DAMNATION WITH LITTLE DIFFICULTY.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/YET ZYX WAS WEAK, FOR EMPEROR XYRIK, THE LAST OF HIS BLOODLINE, HAD GROWN COMPLACENT IN HIS CONQUEST. HE HAD GROWN CARELESS, AND HIS ARMIES SOON STAGNATED ON THEIR ADVANCE. SOON, REBELLION BEGAN, AND CIVIL WAR TURNED THE RESTLESS UNDEAD AGAINST ONE ANOTHER.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IT APPEARED AS IF ZYX WOULD HAVE FINALLY FALLEN, ITS DOMINION CRUMBLING WITH EACH AND EVERY SKELETAL REMAIN OF ITS MILITARY, BUT IT IS AT THAT TIME THAT I SAW AN OPPORTUNITY.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I, ASKARIOS, LORD OF UNDEATH, MASTER OF SECRETS, ALL-POWERFUL (AND HANDSOME) LICH LORD OF SKENTIRA, STAGED A COUP THAT OVERTHREW EMPEROR XYRIK AS HIS FOCUS REMAINED ON THE ENCROACHING WARFRONT.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/CENTURIES HAVE SINCE PASSED, AND I, ASKARIOS THE TYRANT, CONTINUE TO RULE ZYX ABSOLUTELY, MY RULE HAVING NEVER ONCE WANTED.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SUBJUGATED THOSE THAT REBELLED AGAINST ZYX, CULLING ANY WHO DARED ATTEMPT TO DESTROY THE EMPIRE FROM WITHIN.THE DEAD OBEY MY EVERY COMMAND, ENSLAVED TO MY WILL.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THE LIVING HOLD SUCH GREAT FEAR OF ME THAT THEY COWER AT THE MERE MENTION OF MY NAME. MY CONQUEST HAS STRETCHED TO THE VERY CORNERS OF KAZ, AND SOON, I SHALL CLAIM THE REST OF THE WORLD.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THERE IS BUT ONE ISSUE — I AM LONELY.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY CONQUEST HAS GROWN BORING, AND I FIND MYSELF IN NEED OF SOMEONE TO SHARE IN MY SADISM WITH. BUT NONE CAN MOVE PAST THEIR FEARS OF ME ENOUGH TO EVEN ATTEMPT COURTSHIP!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...OR THEY ARE A MINDLESS THRALL, BUT WE ALL HAVE STANDARDS.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! TELL THEM OF YOUR PLAN. YOU KNOW IT BETTER THAN I.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Alright, alright, so... I set up the boss here with some dates. Far off place from here. Paleon City, it's called. TONS of bachelors, bachelorettes, and all the others in-between.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/YES, HE HAS FOUND MANY SUITABLE PARAMOURS FOR MY ROMANTIC ADVANCES.THEY SHALL QUIVER IN DELIGHT AT MY PRESENCE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Anyway, I found a few that may be compatible with his... personality. Seems some of 'em really like the whole 'intimidate, dominate, maim, and deceive' thing.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERFECT! MY CHARMS SHALL APPLY TO THEM TO A GREAT DEGREE, THEN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Though, uh... boss?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHAT, MINION?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/You, uh, may wanna turn the volume down just a teensy little bit. Unlike most of your subjects, they have ears.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/VOLUME? I SPEAK AT A TONE THAT COMMANDS ATTENTIONS AND DENOTES MY POWER.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/(Hells, this will be a disaster...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Alright, well, whatever you say.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THEN WHERE IS THIS... 'PALEON CITY'? TO WHICH PART OF MY DOMAIN ARE WE TO TRAVEL?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/It's... actually across the world from here, boss. Had to get you a glyph pattern for a teleportation circle.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SEE... PROVIDE ME WITH IT, AND WE SHALL HEAD THERE ON THE MORROW!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Yeah, yeah, here ya g—/close/", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios slaps the paper out from Skully's hands.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/READY THYSELVES, DENIZENS OF PALEON CITY, FOR ASKARIOS THE TYRANT WILL SOON BE GRACING THY LANDS IN SEARCH OF LOVE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/*sigh*", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Thumbsup1/I'm sure they'll love you, boss.", "Skully"));
        var endText = new DialogData("/speed:0.03/(Let's get this shit over with.)", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => IntroContinue();
    }
    #endregion

    #region Dialogue Continue
    public void IntroContinue()
    {
        canvas.SetActive(false);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/Well...", "Skully"));
        var endText = new DialogData("/speed:0.03//emote:Thumbsup2/Here we are, boss!", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => IntroEnd();
    }
    #endregion

    #region Dialogue End
    public void IntroEnd()
    {
        canvas.SetActive(true);
        citadel.SetActive(false);
        market.SetActive(true);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/BY THE HELLS, IT IS BRIGHT HERE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/It's called the sun, boss. You just haven't seen it in centuries.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/CAN WE RID OURSELVES OF IT? IT IS MAKING MY BONES BLEACH!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I don't think it happens that fast.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios is bumped into by someone, leaving a smear of ketchup on his cloak from a stray French fry.]", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Move, jackass!", "NPC"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WATCH THYSELF, KNAVE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Psst... Hey, boss, ya might wanna keep it down. Don't wanna make a bad first impression on your future partners, eh?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THAT ONE TOUCHED MY CLOAK WITH ITS DISGUSTING, FLESHY APPENDAGES! I SHALL CUT THEM FROM THEIR JOINTS AS PUNISHMENT! COME BACK HERE, PEASANT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios runs off to chase the individual responsible for dirtying his outfit.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss! Wait up!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully runs in the direction of Askarios's pursuit.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/(This is gonna be a loooooong day.)", "Skully"));
        var endText = new DialogData("/speed:0.03//emote:Smug/Alright, boss. Got a few profiles for ya to choose from. Doesn't matter which one you choose, ya just gotta pick who ya like. I conveniently laid 'em out for ya on this specially made user interface.", "Skully");

        endText.Callback = () => LoadCharacterSelection();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadCharacterSelection()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
}
