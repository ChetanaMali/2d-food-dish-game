using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManeger : MonoBehaviour
{
    [SerializeField] GameObject startScreen, winScreen, loseScreen, pauseScreen;
    static UIManeger instance;
    
    public static UIManeger Instance { get { return instance; } }
    private void Awake()
    {
        if (Instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
        startScreen.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        startScreen.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    public void StartButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        startScreen.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    public void ExitApplication()
    {
        Debug.Log("Exit Application");
        Application.Quit();
    }
    
    public void WinGame()
    {
        Time.timeScale = 0;
        winScreen.SetActive(true);
        pauseScreen.SetActive(false);
        startScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    public void loseGame()
    {
        winScreen.SetActive(false);
        pauseScreen.SetActive(false);
        startScreen.SetActive(false);
        loseScreen.SetActive(true);
    }

}
