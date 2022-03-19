using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class MothmanDateStartScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    private void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/A BEACH? /wait:0.5/I DID NOT PLAN TO BRING ATTIRE FOR SWIMMING ON THIS EXCURSION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You have a swimsuit, boss?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE I DO! DO YOU BELIEVE THAT I WOULD WILLINGLY SUBMERGE MY TYPICAL ATTIRE IN THE BLOOD LAKES OF ZYX? /wait:0.5/THEY ARE FAR TOO EXPENSIVE.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AND IT IS AN HONOR GAZE UPON MY BARE BONES AS I SLOWLY EMERGE FROM THE WATERS, DRIPPING SENSUALLY FROM EACH AND EVERY CAVITY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, boss, can't say I relate to that feeling.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Don't gotta wear a swimsuit if you're dead, /speed:0.2/maaaan...", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Got nothin' to hide down there... Ain't that the point of 'em.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios pauses in thought at the newcomer's observation.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SUPPOSE YOU ARE CORRECT, STRANGER! PERHAPS LOIN SHALL QUIVER AT THE SIGHT OF MY NAKEDNESS, THEN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The man shrugs]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Whatever you say, maaan...", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PRAY, O INSIGHTFUL STRANGER, HAVE YOU SEEN A PARAMOUR IN THIS LOCALE?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Paramour? Like, someone single? Maaan, I ain't checkin' for other people's vibes and shit...", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He sticks his proboscis into his martini, drawing out a long sip.]", "Mothamn"));
        dialogueTexts.Add(new DialogData("/speed:0.03/'Side from me, I can't say I know.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss... he WAS the profile.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERHAPS YOU ARE MY ELIGIBLE BACHELOR, THEN! PRAY, TELL ME THY NAME, O WISE STRANGER.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Name's Greg. Some people call me Mothman.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He shrugs]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Either's fine... Whatever you think fits the vibe.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/GREGORY! YOU STAND IN THE PRESENCE OF ASKARIOS, LICH LORD OF SKENTIRA, TYRANT OF DEATH, AND EMPEROR OF ZYX.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Lotta titles there, maaan. Too much work for me.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Y' here on pleasure or somethin'?", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AM COME TO THIS CITY IN SEARCH OF A PARAMOUR -- A LOVER TO SHARE IN MY RULE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Huh... I'm just here on vacation, maaan. Got tired of being an omen of disaster of for a minute.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/A PORTENT OF ILL OMEN? THEN YOU SHARE IN SUCH PLEASURES AS I -- THE BRINGING OF PAIN AND STANDING AS CAUSE FOR SUFFERING.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Nah... shit just kinda happens when I show up. Like to think people just bring it on themselves in a panic.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Again, he shrugs.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/No scales off my skin, honestly. Less I gotta do, the better.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, THIS ONE IS RATHER LAID BACK! ARE YOU SO SURE THAT HE IS A COMPATIBLE MATCH TO ONE OF MY STATURE", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/'Course, boss. I put in all the work to ensure everyone's a match for you.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(I gotta throw out those extra ads later... and clear my call log.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sounds like you're worryin' too much, maaan. You gotta learn to just let it all just be a vibe.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SPEAK CLEARLY, GREGORY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Like, you gotta learn to go with what happens... Enjoy what comes in life, you know ? Think you're too caught up on makin' sure everything's perfect for you, maaan.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY RULE DID NOT COME FROM WEAKNESS AND COMPLACENCY! I HAVE RULED ZYX FOR CENTURIES AND LIVED FOR MANY MORE THROUGH PERFECTION OF MY CRAFT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/And maybe you just gotta let that perfection become... imperfection, 'Skarios.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ELABORATE.", "Aslarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(It ain't that deep, boss. Eh... maybe it is for you.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Greg sighs, then takes another sip of his martini. Afterwards, he walks back towards the cabana, beckoning Askarios to follow.]", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/C'mere, maaan. Take a seat... have a drink. I'll explain my philosophy to you.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE! MINION, PREPARE NOTES OF OUR DISCUSSION, FOR I WILL BE IN NEED OF THEM LATER.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios heads off to the cabana, where he nearly hits his head on the doorway.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY, IT SMELLS LIKE GLIMMERROOT IN HERE! THE HERBALISTS OF SKENTIRA USED TO SMOKE SUCH AS MUSCLE RELAXANTS IN MY TIME.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Let me know if you want some, maaan. Might make you understand me better.", "Mothman"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(First date... secured? Fuck if I know, honestly.)", "Skully 2"));
        dialogueTexts.Add(new DialogData("", "Confirm"));

        dialogueManager.Show(dialogueTexts);
    }
}
