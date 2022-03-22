using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public Level level;
    public GameOver gameOver;

    public UnityEngine.UI.Text remainingText;
    public UnityEngine.UI.Text remainingSubtext;
    public UnityEngine.UI.Text targetText;
    public UnityEngine.UI.Text targetSubText;
    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Image[] hearts;
    public ScoreBar bar;
    private int heartIdx = 0;
    //private bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i == heartIdx)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int score)
    {
        bar.current = score;

        scoreText.text = score.ToString();





        int visibleHeart = 0;

        if (score >= level.score1Star && score < level.score2Star)
        {
            visibleHeart = 1;
        }
        else if (score >= level.score2Star && score < level.score3Star)
        {
            visibleHeart = 2;
        }
        else if (score >= level.score3Star)
        {
            visibleHeart = 3;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i == visibleHeart)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        heartIdx = visibleHeart;

    }

    public void SetTarget(int target)
    {
        targetText.text = target.ToString();
    }
    public void SetRemaining(int remaining)
    {
        remainingText.text = remaining.ToString();
    }
    public void SetRemaining(string remaining)
    {
        remainingText.text = remaining;
    }
    public void SetLevelType(Level.LevelType type)
    {
        if (type == Level.LevelType.MOVES)
        {
            remainingSubtext.text = "Moves";
            targetSubText.text = "Target Score";
        }
        if (type == Level.LevelType.OBSTACLE)
        {
            remainingSubtext.text = "Moves";
            targetSubText.text = "Trash Remaining";
        }
        if (type == Level.LevelType.TIMER)
        {
            remainingSubtext.text = "Time Remaining";
            targetSubText.text = "Target Score";
        }
    }

    public void OnGameWin(int score)
    {
        gameOver.ShowWin(score, heartIdx);
        //isGameOver = true;
    }
    public void OnGameLose()
    {
        gameOver.ShowLose();
        //isGameOver = true;
    }


}
