using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Leaving this public so it can be accessed from anywhere in game.
    //Should always start on "False" or Pause Menu will be enabled at start.
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        //Will Load Main Menu/Title Screen.
        //Time.timeScale must be set back to 1f or it will still be paused on Title Screen. 
        //If using this method anywhare else, REMEMBER THIS!!
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScreen");

        Debug.Log("This Goes to Main Menu.");
    }
    public void QuitGame()
    {
        //Will Quit Game from current scene. BECAREFUL WHERE YOU USE THIS!!
        //In Editor this will do nothing.
        Debug.Log("Game End.");
        Application.Quit();
        
    }

    
    public void RestartGame()
    {
        //Will Restart Current Scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        Time.timeScale = 1f;

    }
}
