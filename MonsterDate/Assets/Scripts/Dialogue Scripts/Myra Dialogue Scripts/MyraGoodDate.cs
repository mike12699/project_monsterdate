using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MyraGoodDate : MonoBehaviour
{
    public DialogManager dialogueManager;
    public GameObject hotel;
    public GameObject market;
    public AudioSource hotelMusic;
    public AudioSource marketMusic;

    void Start()
    {
        GoodDateStart();
    }

    #region Dialogue Start
    public void GoodDateStart()
    {
        hotel.SetActive(true);
        market.SetActive(false);
        hotelMusic.Play();
        marketMusic.Stop();

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/MINION, I DO BELIEVE HER INTEREST IN PAINTING THE INNUMERABLE INTRICACIES OF MY CHEST CAVITY WAS ENLIGHTENING TO HER INTEREST IN ME, NO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Well, can't say ya seemed to have scared her, boss. Thinkin' that's... probably a good thing.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/HER NERVOUS NATURE SEEMED TO HAVE QUELLED IN MY PRESENCE! I WOULD POSIT SUCH AS A PERSONAL VICTORY.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/She sure focused more, that's true. Ya think ya made a good impression?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I CAN ONLY ASSUME HER LINGERING GAZE UPON MY NETHERS DISPLAYED HER PIQUED ADORATION!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Eh, I guess s? Wait, where was she lookin'?!", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/IN OUR PRIVATE MOMENTS, SHE ASKED I STRIP FOR THE BETTERMENT OF HER ARTWORK!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Oh... Well, alright.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Sad/(Let me pray she was just tryin' to get the details right.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/NEVERTHELESS, WE SHALL REST! THERE ARE STILL YET ROMANTIC PURSUITS TO...PURSUE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Thumbsup1/Yeah...Leeeeeet's get on that, boss.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Thumbsup1/(Don't think too hard about what she saw, don't think too hard about what she saw, don't?.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Two weeks later.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:myra_notif/[Askarios's date-seeking app buzzes with a series of notifications.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/GAH! MINION, THIS DEVICE IS...VIBRATING! PRAY, WHAT ELEMENTAL FORCE HATH POSSESSED IT?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/Boss, that's... Just open the fuckin' app.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:askarios_clacking/[Askarios blinks, then struggles to unlock the phone. The capacitive touch screen doesn't easily react to his bony fingers.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Confused/DAMNED THING!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[After a few minutes of poorly-made attempts, some infused with minor cantrips and spells of ridiculous power, he eventually manages to get the app open.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Upon the screen, the following text is displayed:]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SuraimuSuraimu: ASKARIOS! Uhm, sorry, I mean... Anyway. Uhm, can you come meet me at the market? I wanna... update you on... my art test. Uhm... Yeah, just meet me!!!1!", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/MINION! I BELIEVE ANOTHER PARAMOUR HAS CONTACTED ME!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Boss, that's...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Skully pinches the bridge of where his nose used to be.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/That's Myra.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SUCCESS, THEN! SHE HAS FOUND THE NEED TO DATE ME ONCE AGAIN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Let's not be hasty now, boss. She might just wanna meet up with ya.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ONWARD, MINION! TO THE MARKET!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/[Skully sighs.]", "Skully"));
        var endText = new DialogData("/speed:0.03//emote:Annoyed/Right... Let's go.", "Skully");

        endText.Callback = () => GoodDateContinue();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    #region Dialogue Continue
    public void GoodDateContinue()
    {
        hotel.SetActive(false);
        market.SetActive(true);
        hotelMusic.Stop();
        marketMusic.Play();

        var dialogueTexts = new List<DialogData>();

        dialogueTexts.Add(new DialogData("/speed:0.03/AH, SUCH MEMORIES OF THIS PLACE! 'TWAS HERE THAT WE FIRST ARRIVED IN THIS VERY CITY, NO?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Yeah, like... /wait:0.5/the one time we came here... /wait:0.5/two weeks ago.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/SUCH BITTERSWEET MEMORIES, SO VERY LONG AGO! MY, HOW I DID NOT THINK TO GROW NOSTALGIC ALREADY.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/...", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/U-uhm, h-hey, Askarios!", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Sliding through the legs of the dense crowd is Myra.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03/GOOD EVENING, MYRA! PRAY, DID THINE EXAMINATION PROCEED SMOOTHLY?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/U-uhm, y-yeah! I was... a-actually just... going to tell you about that.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/[She lets out a nervous chuckle, then quivers a tiny bit in anxiety.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/I, u-uhm, got a-an A+!", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/CONGRATULATIONS, THEN, MYRA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Shocked/WAIT... IS THAT A PLEASANT RESULT? I HAVE NOT PURSUED AN EDUCATION IN CENTURIES.", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Oh, we know.)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/T-that's... the best you can get, y-yeah.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Myra pulls her hand nubs in and starts to wring them passively.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/S-sorry. I... don't like to b-boast.", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/'TIS EXCITING, MYRA! PRAY, LET MINE COFFERS SPILL FOR THEE ? WHAT SORT OF REWARD WOULDST THOU ENJOY?", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She perks up at the thought, but she is quick to wave her hands in front of her dismissively.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Crying/N-no, don't do that! I'm, u-uhm, p-perfectly fine without a gift, honest!", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Crying/[She looks as if she's about to cry.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:myra_pat/[Askarios reaches forth to pat her head, pulling off globs of her body with each lowering of his hand. Myra is quick to pull away after scooping the slime from his fingers.]", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/NO TEARS, PLEASE! 'TIS A DAY OF CELEBRATION, THAT YOU WOULD (WITH MY ATTRACTIVE FORM AS YOUR SUBJECT) SUCCEED WITH SUCH PRAISE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ALLOW THYSELF THIS MOMENT OF EXCESS, THAT I MAY COMMEMORATE THE OCCASION WITH THEE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Crying/[Myra quivers again, then wipes her tears away, huffing out a breath of acceptance.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/I-I guess...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[She pauses to think, then lets out a slight sound as a thought comes to her.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/U-uhm... I t-think there's... a little store that has some e-extra slime on sale! I've b-been wanting to g-get myself some new clothes...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/(Slimes wear clothes...?)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/A-and, uhm, I-I think there's a little stall s-somewhere that has... d-dango. I've b-been wanting some for a while...and bubble tea...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THEN PURSUING THESE MERCHANTS, WE SHALL! I HAVE NOT INDULGED IN SUCH CUISINES, EVEN IN THE LANDS OF SKENTIRA!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/LEAD THE WAY, MYRA, FOR MY COFFERS SHALL OFFER THEE ONLY THE HIGHEST OF QUALITY GOODS!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Happy/U-uhm...ok! L-let's g-go...", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Myra begins to slide away, leaving a trail of goop behind her with every shift of her body.]", "Myra"));
        dialogueTexts.Add(new DialogData("/speed:0.03/SEE, MINION! COINAGE CAN OFT RESULT IN THE BETTERMENT OF LOVE!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/When was that an argument, boss?", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Blush/...IT WAS NOT! BUT I SHALL DECLARE SUCH AN IMPORTANT POINT FOR MY INEVITABLE MEMOIR AND TOME OF ADVICE ON PARAMOURSHIP!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Laugh/(Sure that'll sell fantastically. Watch him title it 'Gettin' Boned!', ha! Wait, that'd be my joke...)", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/Let me guess ? I'll have to be your editor.", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03/THOU ART WISE, MINION! THOU ART WISE...", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/ONWARD, THEN!", "Askarios"));
        dialogueTexts.Add(new DialogData("/speed:0.03/[Askarios makes his way after Myra, who moves at an incredibly slow pace, almost like a slug.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//sound:slipnslide_falls/[In his wake, countless people from the crowd let out screams as they slip and slide into one another ? the slime trail being the perpetrator.]", "Narrator"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/[Skully sighs.]", "Skully"));
        dialogueTexts.Add(new DialogData("/speed:0.03//emote:Annoyed/Onward, woo...", "Skully"));
        var endText = new DialogData("/speed:0.03//emote:Thumbsup1/[He pumps his fist in a lazy, train conductor-like fashion, then hunches his shoulders forward as he slowly follows after the two, each of his steps touched with exhaustion and irritation.]", "Skully");

        endText.Callback = () => LoadMyraMatch3Pt2();

        dialogueTexts.Add(endText);
        dialogueManager.Show(dialogueTexts);
    }
    #endregion

    void LoadMyraMatch3Pt2()
    {
        SceneManager.LoadScene("SlimeGirlGoodNeutralPuzzle");
    }
}
