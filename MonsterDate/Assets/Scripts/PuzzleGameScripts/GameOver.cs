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
}
