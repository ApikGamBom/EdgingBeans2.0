using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Slid Controller")]
    public SliderControl sliderController;

    [Header("GameObjects")]
    public GameObject pauseMenu;
    public GameObject Crosshair;
    public GameObject optionsTab;

    [Header("Floats")]
    public float UiCountdown;

    [Header("Bools")]
    public static bool isPaused = false;
    public bool CountDone;
    public bool optionOpen = false;

    [Header("Other")]
    public GameObject mainMenu;
    
    public void Update()
    {
        UiCountdown = sliderController.ResumeDelayValue;
    }
    public void playGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }

    public void openSettings()
    {
        optionsTab.SetActive(!optionsTab.activeSelf);
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        optionOpen = !optionOpen;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
