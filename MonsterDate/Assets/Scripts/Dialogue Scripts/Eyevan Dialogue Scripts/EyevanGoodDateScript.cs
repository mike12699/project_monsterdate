using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class EyevanGoodDateScript : MonoBehaviour
{
    public DialogManager dialogueManager;
    public GameObject hotel;
    public GameObject dinner;

    void Start()
    {
        GoodDateStart();
    }

    #region Dialogue Start
    public void GoodDateStart()
    {
        hotel.SetActive(true);
        dinner.SetActive(false);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! SUCH AN ACADEMIC MIND AS EYEVAN'S IS A PLEASANT SIGHT TO BEHOLD!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/How so, boss?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HE INDULGED ME IN SUCH DEEP CONVERSATION, ANSWERING MY EVERY QUESTION WITHOUT DELAY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/He ask much about you?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NO! WAS HE SUPPOSED TO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Not at all, boss. I think your presence is pretty clearly laid out.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/WELL, MY NAME POSSESSES MUCH RENOWN, YOU ARE AWARE! PERHAPS HE HAS HEARD OF ME IN HIS STUDIES!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/...Sure! Let's go with that.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I AWAIT OUR NEXT VENTURE, THAT WE MAY DISCUSS FURTHER TOPICS WITH HIS GREAT INSIGHT!", "Askarios"));
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

        endText.Callback = () => GoodDateContinue();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    #region Dialogue Continue
    public void GoodDateContinue()
    {
        hotel.SetActive(false);
        dinner.SetActive(true);

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/[Under the growing moonlight of the evening, the restaurant has grown quite populated. Almost every table is full, and it's impossible to make anyone out from a distance.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/EYEVAN! PRAY, WHERE ART THOU?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/[Askarios, without asking, starts invading peoples' space, looking for the man.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HELLS, THERE ART MANY OF THEE OUT ON THIS EVE...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss, ya shouldn't... /wait:0.5/Ah, forget it.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Right behind Askarios, staring straight at his back from a candlelit table, is Eyevan. His gaze is blank, tinged with annoyance.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[While he watches the lich struggle, he snacks on what appears to be fresh bruschetta, coupled with a cocktail.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Eventually, Askarios turns a 180 with a flourish, then stares down the man.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AH! THERE THOU ART!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Evening.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Eyevan offers Askarios a lazy wave of his wrist, then immediately goes back to his appetizer and alcohol.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios takes a seat.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I SEE THOU ART INDULGING IN DINNER PRIOR TO MY ARRIVAL! MINE APOLOGIES FOR THE DELAY.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed1/[Eyevan shrugs.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Whatever. Honestly, as long as you ended up making it, I don't really care.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/(Now be real honest about that statement. Or don't. You do you.)", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PRAY TELL, WHAT STUDIES HAST THOU PURSUED SINCE OUR LAST DISCUSSION? I NOW KNOW MUCH OF THY STUDIES AND PERSONAL INFORMATION, AND I MUST INQUIRE FURTHER! PERCHANCE THOU WOULDST EVEN WISH ASK ABOUT ME?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Surprised/Studies? Oh, right.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/[He clear his throat.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, in the last week or so, I finished reading three novels or so. Pretty big investment of time, I'd think.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/SUCH SPEED! EVEN I COULDST NOT PARSE TEXTS WITH SUCH QUICKNESS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Do you read often?", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IT HAS BEEN SOME TIME, I WOULDST STATE! THE ARCHIVES OF ZYX SCARCELY CONTAIN SUCH FICTION AS THOU ART WONT TO ENJOY!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sounds... pretty boring, honestly. Guessing it's all religious texts?", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/'TIS ALL TALES OF MINE CONQUEST! OH, THEY ARE SUCH WONDERS TO LEARN OF, THOUGH I AM EVER AWARE OF HOW SUCH TALES END!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/[Eyevan takes a long sip of his peach-colored drink.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, guess I was right. Pretty boring.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/PERHAPS TO AN OUTSIDER! FOR THOSE OF MINE HOMELAND AND MINE EMPIRE, THEY ART QUITE THE INTRIGUING SORT!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(You only say that because you're the subject.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed1/[Eyevan shrugs, then hails over a waitress, whom he orders a hefty array of entrée's from — far too much for one person, no matter the size. He's absolutely banking on leftovers.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AH! SERVANT, FETCH ME YOUR FINEST WINE AND ANIMALIAN ENTRAILS, COOKED TO PERFECTION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[The waitress blinks, then writes down 'steak, well done' on her pad. Afterwards, she leaves.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/So, what's it like being a ruler and all that? I'm sure you have plenty of money and power.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AH, IT IS A POSITION OF PLEASURE! TO DOMINATE SO EASILY BRINGS SUCH ECSTASY, AND THE WEALTH IN MINE COFFERS IS BOUNDLESS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IN MINE YOUTH, WHEN I WAS A MERE APPRENTICE OF MAGICKS, I COULDST NOT IMAGINE MINESELF IN SUCH A POSITION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/TO HAVE COMMANDED THE DEAD, RAISED SOULS FROM THE BEYOND, AND REAPED THE REWARDS OF CONQUEST — SUCH THINGS CANNOT BE EXPLAINED WITH MERE WORDS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Eyevan smirks.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/And... /wait:0.5/you don't have someone sharing in that with you?", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NO! 'TIS WHY I TRAVELLED TO THIS CITY, SEARCHING FOR LOVE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Surprised/Huh... /wait:0.5/You'd think that anyone would just love holding the throne with you, enjoying the excess and commanding death itself to serve you.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He shrugs again, then shakes his head dramatically.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Too bad that I'm no mage, else I'm sure I'd be such a better candidate for your love.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/[Askarios gasps.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/TO SUCH AN ACADEMIC MIND AS THINE, THE ART OF NECROMANCY SHOULDST PROVE RATHER EASY! 'TIS MERELY A MATTER OF UNDERSTANDING RUNIC PATTERNS, STRATAGEMS, AND INCANTATIONS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oh, that sounds so easy! I'm sure such a humble person like me would learn pretty quick from such a master of the craft as you!", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DEAREST ME, WOULDST THOU WISHEST MINE TEACHINGS? NEVER HAVE I HAD A PROTEGÉ, AND TO HAVE ROMANCED MINE PUPIL? 'TIS A PAIRING MADE IN THE HEAVENS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/[Eyevan crosses his arms and tilts his head, tapping on his eye with his finger.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Huh... /wait:0.5/Well, if you paid your student well and let him wear the crown, too...", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[He smirks again.]", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/You know, I think I'll take up the offer, assuming you're willing, Askarios.", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed1/Only with my knowledge could... /wait:0.5//emote:Thinking/Zyx? /wait:0.5//emote:Surprised/Yeah, Zyx. /wait:0.5/Only with my knowledge and academics (according to you) could your nation improve tenfold!", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Closed/Plus, having a little army of skeletons to do things for me would be pretty nice...", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/AH, OF COURSE! I SHALT INDULGE THEE IN THE BASICS WHILST WE FEAST, IF THOU WOULDST WISH!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Sure! You do whatever it takes to make our relationship even more interesting, hmm?", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[At this point, the waitress returns with Askarios's steak, cooked dark, and a multitude of platters for Eyevan, with each containing a completely different dish.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/DELIGHTFUL! THEN LET US BEGIN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Yeah, let's! I'll think about writing my two weeks', too...", "Eyevan"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Ya know, I'm not even gonna stop this from happening. If the boss wants to get used, he can get used. It ain't my business at this rate.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios clears his throat, preparing for a speech.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IN THE BEGINNING OF DEATH, THERE IS BUT A SOUL BOUND TO A VESSEL OF FLESH...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[In the coming hour, Askarios begins to explain the concepts of necromancy in great detail.]", "Narrator"));
        var endText = new DialogData("/speed:0.03/[At times, he draws some concerned glances from the nearby patrons of the restaurant, but Eyevan is intrigued... whether he genuinely cares or not.]", "Narrator");

        endText.Callback = () => LoadEyevanMatch3Pt2();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadEyevanMatch3Pt2()
    {
        SceneManager.LoadScene("EyevanGoodNeutralPuzzle");
    }
}
