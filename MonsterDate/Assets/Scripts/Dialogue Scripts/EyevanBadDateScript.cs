using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class EyevanBadDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! DID EYEVAN SEEM SHORT ON HIS ANSWERS TO THEE?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Huh? Nah, there probably just wasn't much to say.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/YET MINE QUESTIONS WERE QUITE BROAD! HAD IT BEEN MINE OWN RESPONSE, I WOULDST HAVE PROVIDED ENOUGH INFORMATION THAT ONE COULDST PEN A NOVEL!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(I'm well aware of that one.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Eh, I wouldn't take it too personally, boss. Workin' at a bookstore is hard work, so he probably just didn't have the energy.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Or the interest.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HMM.PERHAPS I SHALT NEEDS BETTER WORD MINE INQUIRIES, THEN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Whatever you think would help, boss. Whateeeeever you think.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SHALT RETREAT TO MINE THOUGHTS, THEN! A SCHOLAR'S KNOWLEDGE IS ONLY AS STRONG AS THE CURIOSITY THAT SUMMONED IT FORTH!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(I pity Eyevan in this scenario.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[A week and a half later, at dusk.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios's phone buzzes. Somehow, he figured out how to raise the power level of the vibration, and the bones near his pocket rattle in tandem with the device's notification.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/GAH! MINION, WHAT MANNER OF SORCERY CAUSES MY LOINS TO QUAKE SO?!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Uh... /wait:0.5/You should probably get that checked out, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHERE ART THOU, DEMONIC FORCE?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios fumbles around with his cloak before pulling out his smartphone, managing to answer the call in the act.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/BLASTED INSTRUMENT OF ELECTRICITY! WHAT DOST THOU WANT?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, if you didn't want to talk, I can just hang up. I have other things I could be doing.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[On the screen, Eyevan's name is displayed.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HELLO? WHO SPEAKETH TO ME? HELLS ABOVE, THEY HAVE FASHIONED COMMUNICATIVE SPELLCRAFT INTO MERE ELECTRONICS?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed2/...", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Eyevan. From the bookstore.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios furrows his brow for a moment, then the realization dawns on him.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/AH! THE VINTNER WITH A PENCHANT FOR NOVELS! PRAY, WHY DOST THOU CALLEST ME ON THIS DAY?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I wanted to know if you wanted to get dinner. There's a nice little restaurant in town, but I've never been. Too expensive for my wages.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/You're buying, of course.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/OF COURSE, SIR OCULAR! SUCH AN ACADEMIC DESERVES HIS DUE, BOTH IN COIN AND OTHERWISE! I SHALT BE'ST THERE ANON!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/[A chuckle is heard from the phone.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Good. I'll get us a table.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed1/...And me some appetizers.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DO NOT INDULGE THYSELF TOO FULLY PRIOR TO MINE ARRIVAL, FOR I SHALT NEEDS POUR MINE COFFERS FOR OUR BETTERED SATISFACTION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Gotcha. Well, I'll see you there.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed1/Don't take too long. I ain't got the money to pay for it myself.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The phonecall ends with a beep.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! RETRIEVE MINE COINPURSE — I POSSESS A NEWFOUND NEED FOR IT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(You're really just lettin' him walk all over you, huh? Well, I ain't gonna stop 'im.)", "Skully"));
        var endText = new DialogData("/speed:0.03/Right away, boss.", "Skully");

        endText.Callback = () => LoadEyevanDatePt2();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadEyevanDatePt2()
    {
        SceneManager.LoadScene("EyevanDatePt2");
    }
}
