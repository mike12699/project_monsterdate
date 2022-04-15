using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class IntroSceneScriptPt2 : MonoBehaviour
{
    public DialogManager dialogueManager;
    void Start()
    {
        var text = new DialogData("/speed:0.03/Here we are, boss!", "Skully");

        dialogueManager.Show(text);

        text.Callback = () => LoadIntroScenePt3();
    }

    void LoadIntroScenePt3()
    {
        SceneManager.LoadScene("IntroScenePt3");
    }
}
