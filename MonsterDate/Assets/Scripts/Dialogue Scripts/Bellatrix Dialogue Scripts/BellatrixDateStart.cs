using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class BellatrixDateStart : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    private void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/A LICHYARD? MY, MY, THIS PARAMOUR-TO-BE HAS AN AFFINITY FOR THE UNDEAD, THEN?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, all I know is that they come here often.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERHAPS THEY ARE A LICH THEMSELVES! I WOULD SO ADORE TO SPOT ANOTHER OF MY KIND AND CRAFT.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Sad/Eh... /wait:0.5/ya didn't look at the picture I gave you, huh, boss?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:bella_digging/NO! WAS I SUPPOSED TO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Can you keep it down, please? I'm trying to find inspiration here.", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:dirt_footsteps_bella/[An insectoid woman appears, quietly approaching from near a suspiciously large mound of dirt.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/GAH! AN INSECT?! MINION, WHERE IS MY PARAMOUR?!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Sad/Seriously, keep it down. The dead rest here. Be respectful.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, IT IS WAVING ITS MANDIBLES AT ME!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Psst, boss... that IS the person I found for you.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios clears his throat cavity, then attempts lowering his voice.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DEAR ME, MY MISTAKE! HOW QUAINT IT IS THAT I WOULD RUN ACROSS ANOTHER SOUL IN SUCH A GRIM LOCALE?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He is, in fact, not any quieter than before.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She puts her hand to her head and pinches the space between her eyes.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Anyway! I don't think I've seen you before, so who are you?", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AM ASKARIOS THE TYRANT! LICH LORD OF SKENTRIA, CONQUERER OF ZYX!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Her eyes train on Askarios.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Neat! I'm Bellatrix.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She offers Askarios a small wave, then tilts her head in a gesture of curiosity.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/So... you're a tourist?", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AM HERE ON NO TOUR!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sure sounds like you're here for pleasure, though.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ERM... PERHAPS SO, THEN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Cool! Got any questions?", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHY DO YOU NOT FEAR MY STATUS -- MY NAME? IS IT OF NO IMPORTANCE TO YOU?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Not really! I'm just some girl in a band. I dunno about all that world history stuff.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! SHE IS AVOIDING MY QUESTION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss, we're on the other side of the planet.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Angry/I can hear you, you know.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PRAY TELL, WHAT SORT OF MUSIC DO YOU PLAY? YOUR APPEARANCE SPEAKS... BARDIC!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oh! /wait:0.5/I'm the lead singer for a metal band called the Carrion Creepers.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Well, that wasn't on the profile...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I actually came here to get some inspo for a new song. I wanna call it 'The Death March'.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AM QUITE FAMILIAR WITH DEATH! IN FACT, I AM A MASTER OF NECROMANCY -- A LORD OF UNDEATH!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oooooh... /wait:0.5/So you could help me out, then?! I wanna write some accurate lyrics, and looking at corpses only gets you so far.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ARE THEY NOT BENEATH THE EARTH?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Not if you have ambition and a shovel.", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:bella_awksilence//emote:Confused/...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Disappointed/...", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Her eyes train on Askarios.]", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, grave robbing also wasn't on the profile...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/What? Don't liches raise the dead? How am I the weird one here?", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/She's got you there, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERHAPS SO! BUT REGARDLESS, LET US SPEAK ON THANATOLOGY! FURTHER CONVERSATION IS LIKELY TO OCCUR AS WELL.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Fine by me!", "Bellatrix"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NOW... /wait:0.5/TO A SEATING AREA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:bella_dirt-pairfootsteps-away/[The two head off towards a wrought iron bench that sits near the grave dirt mound.]", "Narrator"));
        var endText = new DialogData("/speed:0.03//emote:Happy/(Nice... /wait:0.5/first date secured! Don't fuck it up, boss.)", "Skully");

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);

        endText.Callback = () => LoadBellatrixMatch3();
    }
    #endregion

    private void LoadBellatrixMatch3()
    {
        SceneManager.LoadScene("BugGirlPuzzle");
    }
}
