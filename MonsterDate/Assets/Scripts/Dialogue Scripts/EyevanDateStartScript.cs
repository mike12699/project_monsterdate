using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class EyevanDateStartScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/SO CALM IS THE ATMOSPHERE HERE, MINION! SUCH AN ARCHIVE SPEAKS THAT I SHALL BE MEETING QUITE THE SCHOLAR!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, boss, it's... more of a store, but...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHY YES, A LIBRARY IS WHERE ONE STORES BOOKS.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/No, boss, not—", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I must ask you to quiet down a little, sir. The other customers are trying to read.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[From what appears to be an integrated café approaches an individual with an eyeball for a head. Judging by how he's wearing a name tag and smells like espresso, it looks like he's an employee.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/AH, A SERVANT OF THE ARCHIVE! PRAY, TELL ME WHERE YOUR HIGHEST OF SCHOLARS ARE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed1/...Or don't. Whatever.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He sighs, shakes his eye, then shrugs.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Book signings usually happen on the weekends. Today's not one of them.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SEE. THEN TO WHOM DO I SPEAK AT THIS CURRENT VENTURE?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I'm Eyevan. Yes, I get the joke. /wait:0.5//emote:Annoyed2/No, I don't care if you think it's funny.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Now, my boss has made it mandatory that I ask all new customers if they want a discounted drink. So, can I get you something, sir, or are you just going to be loud and disruptive.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/BRING ME YOUR FINEST WINE! IT IS IN MY INTEREST TO INDULGE IN SUCH LUXURIES WHILE ON SUCH AN EXHAUSTING EXCURSION AS THIS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Right... /wait:0.5/And who should I put this order in for?", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AM ASKARIOS! MASTER OF UNDEATH, LICH LORD OF SKENTIRA, AND UNDYING EMPEROR OF ZYX!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/That's nice. Anyway, I'll be right back.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Eyevan returns to his spot behind the counter, his shoulders held forward in a slight hunch.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, THIS ONE SEEMS IMPRESSED BY MY PRESENCE! A DISCOUNT FOR MERELY ARRIVING? AH, SUCH RECOGNITION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Yeah, I think— Let's just go with that, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/By the way, I hope you know that he's the date.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERFECT! THEN HE IS ALREADY AWARE OF WHAT GREATNESS AWAITS HIM IN ROMANCE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Sure, boss, yeah.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Within a few minutes, Eyevan returns, holding a plastic cup with a purple straw. On the side, written in black marker, is 'Eskairyos.' The drink is visually a deep red, but nothing really screams 'wine.']", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Here you are, sir.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MY THANKS, FRIEND!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios puts the straw in his mouth and takes a long sip of the cup's contents. A slight dribbling noise soon follows, and splatters of reddish-purple can be seen on the hardwood floor beneath him.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DELIGHTFUL! WHAT VINTAGE IS THIS, MIGHT I ASK?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Velch's 100% Concord Grapes.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WONDERFUL! I SHALL SEND MY MINIONS TO SEEK MANY BARRELS OF SUCH A FINE DRINK!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Yeah, you do that. Now, can I get back to work, or do you need something else?", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHY YES, ACTUALLY! I WOULD LIKE TO LEARN MORE ABOUT YOU, EYEVAN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sir, I just work here. I'd like to get back to reading the next Spires of the Moon book, if you don't mind.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SO YOU ARE AN IMPRESSIVE ACADEMIC, THEN? MANY OF ZYX ARE ILLITERATE CHAFF, AND MY CITADEL'S ARCHIVES OVERFLOW WITH TEXTS THAT FEW CAN PARSE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sounds like something you, their emperor, should fix.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He shrugs again.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Not my problem.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/BELIEVE ME, I HAVE TRIED! IT IS DIFFICULT TO TEACH THOSE THAT LIVE IN CONSTANT TERROR!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(You haven't fuckin' tried at all...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Glad to see that I avoided that fear, then.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/INDEED SO! AND AS SUCH, I MUST ASK IF WE MAY SPEAK ON OUR ACCOMPLISHMENTS — MY CONQUESTS, YOUR STUDIES AND KNOWLEDGE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/[He sighs once more.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Guess it takes away some of the monotony.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Look, if I humor you, will you tip me more.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WHAT IS THIS 'TIP' YOU SPEAK OF?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss, it means ya give him money for doing a good job serving you.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THEN OF COURSE! YOU SHALL BE SHOWERED IN THE ETERNAL COFFERS OF SKENTIRA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[If an eye could smirk, Eyevan is doing so.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Perfect. Why don't we go over to the counter and have a chat, then, hmm?", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AS YOU WILL IT, SO IT SHALL BE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The two head off to the café, with Askarios taking a seat on a stool and Eyevan leaning on the counter.]", "Narrator"));
        var endText = new DialogData("/speed:0.03/(Date... secured, I guess? Yeah, let's go with that.)", "Skully");

        endText.Callback = () => LoadEyevanMatch3();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadEyevanMatch3()
    {
        SceneManager.LoadScene("EyevanPuzzle");
    }
}
