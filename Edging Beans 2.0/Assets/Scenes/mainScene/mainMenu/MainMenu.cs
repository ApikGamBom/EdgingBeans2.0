using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    
    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void openSettings()
    {

    }

    public void quitGame()
    {

    }
}
