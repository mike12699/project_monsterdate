using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadMothmanDate()
    {
        SceneManager.LoadScene("MothmanDateStart");
    }

    public void LoadAskariosDate()
    {
        SceneManager.LoadScene("BellatrixDateStart");
    }

    public void LoadAskariosMatch3()
    {
        SceneManager.LoadScene("BugGirlPuzzle");
    }

    public void LoadMothmanMatch3()
    {
        SceneManager.LoadScene("MothManPuzzle");
    }
}
