using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject screenParent;
    public GameObject scoreParent;
    public UnityEngine.UI.Text winText;
    public UnityEngine.UI.Text loseText;
    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Image[] stars;
    public UnityEngine.UI.Image passImage;
    public UnityEngine.UI.Image failImage;










    // Start is called before the first frame update
    void Start()
    {
        screenParent.SetActive(false);

        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowLose()
    {
        screenParent.SetActive(true);
        winText.enabled = false;
        failImage.enabled = true;
        passImage.enabled = false;
        scoreParent.SetActive(false);

        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            animator.Play("GameOverShow");
        }
    }

    public void ShowWin(int score, int starCount)
    {
        screenParent.SetActive(true);
        winText.enabled = true;
        loseText.enabled = false;
        failImage.enabled = false;
        passImage.enabled = true;

        scoreText.text = score.ToString();
        scoreText.enabled = false;

        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            animator.Play("GameOverShow");
        }

        StartCoroutine (ShowWinCoroutine (starCount));
    }

    private IEnumerator ShowWinCoroutine(int starCount)
    {
        yield return new WaitForSeconds(0.5f);

        if (starCount < stars.Length)
        {
            for (int i = 0; i <= starCount; i++)
            {
                stars[i].enabled = true;

                if (i > 0)
                {
                    stars[i - 1].enabled = false;
                }
                yield return new WaitForSeconds(0.5f);
            }
        }
        scoreText.enabled = true;
    }

    #region Bellatrix Match 3
    public void OnBellatrixPassClicked()
    {
        //This will continue game. Connect this to each characters specific date. Scene transition to next part of date.
        //If next scene is frozen at start use "Time.timeScale = 1f;" at the end of this method.
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("BellatrixGoodDate");
        }
    }

    public void OnBellatrixFailClicked()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("BellatrixBadDate");
        }
    }

    public void BellatrixGoodNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("BellatrixGoodEpilogue");
        }
    }

    public void BellatrixGoodNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("BellatrixNeutralEpilogue");
        }
    }

    public void BellatrixBadNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("BellatrixNeutralEpilogue");
        }
    }

    public void BellatrixBadNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("BellatrixBadEpilogue");
        }
    }
    #endregion

    #region Mothman Match 3
    public void OnMothmanPassClicked()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MothmanGoodDate");
        }
    }

    public void OnMothmanFailClicked()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MothmanBadDate");
        }
    }

    public void MothmanGoodNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MothmanGoodEpilogue");
        }
    }

    public void MothmanGoodNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MothmanNeutralEpilogue");
        }
    }

    public void MothmanBadNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MothmanNeutralEpilogue");
        }
    }

    public void MothmanBadNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MothmanBadEpilogue");
        }
    }
    #endregion

    #region Eyevan Match 3
    public void OnEyevanPassClicked()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("EyevanGoodDate");
        }
    }

    public void OnEyevanFailClicked()
    {
        if (winText.enabled == false && loseText.enabled == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("EyevanBadDate");
        }
    }

    public void EyevanGoodNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("EyevanGoodEpilogue");
        }
    }

    public void EyevanGoodNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("EyevanNeutralEpilogue");
        }
    }

    public void EyevanBadNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("EyevanNeutralEpilogue");
        }
    }

    public void EyevanBadNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("EyevanBadEpilogue");
        }
    }
    #endregion

    #region Myra Match 3
    public void OnMyraPassClicked()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MyraGoodDate");
        }
    }
    public void OnMyraFailClicked()
    {
        if (winText.enabled == false && loseText.enabled == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MyraBadDate");
        }
    }
    public void MyraGoodNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MyraGoodEpilogue");
        }
    }

    public void MyraGoodNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MyraNeutralEpilogue");
        }
    }

    public void MyraBadNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MyraNeutralEpilogue");
        }
    }

    public void MyraBadNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MyraBadEpilogue");
        }
    }
    #endregion

    #region Skully Match 3
    public void OnSkullyPassClicked()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SkullyGoodDate");
        }
    }

    public void OnSkullyFailClicked()
    {
        if (winText.enabled == false && loseText.enabled == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SkullyBadDate");
        }
    }

    public void SkullyGoodNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SkullyGoodEpilogue");
        }
    }

    public void SkullyGoodNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SkullyNeutralEpilogue");
        }
    }

    public void SkullyBadNeutralPass()
    {
        if (winText.enabled == true && loseText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SkullyNeutralEpilogue");
        }
    }

    public void SkullyBadNeutralFail()
    {
        if (loseText.enabled == true && winText.enabled == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SkullyBadEpilogue");
        }
    }
    #endregion
}
