using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void LoadCharacterSelection()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void LoadMothmanDate()
    {
        SceneManager.LoadScene("MothmanDateStart");
    }

    public void LoadBellatrixDate()
    {
        SceneManager.LoadScene("BellatrixDateStart");
    }

    public void LoadEyevanDate()
    {
        SceneManager.LoadScene("EyevanDateStart");
    }

    public void LoadMyraDate()
    {
        SceneManager.LoadScene("MyraDateStart");
    }

    public void LoadSkullyDate()
    {
        SceneManager.LoadScene("SkullyDateStart");
    }

    public void LoadRules()
    {
        SceneManager.LoadScene("RuleScreen");
    }

    public void LoadBellatrixMatch3()
    {
        SceneManager.LoadScene("BugGirlPuzzle");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
