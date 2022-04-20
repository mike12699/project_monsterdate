using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class SkullyDateStartScript : MonoBehaviour
{
    public DialogManager dialogueManager;

    #region Character Dialogue
    void Start()
    {
        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION!I HAVE MADE MY DECISION!", "Askarios"));
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

        endText.Callback = () => LoadSkullyDateStartPt2();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadSkullyDateStartPt2()
    {
        SceneManager.LoadScene("SkullyDateStartPt2");
    }
}
