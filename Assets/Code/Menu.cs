using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // start button
    public void Play()
    {
        SceneManager.LoadScene("Level_1");
    }

    // instructions button
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    // quit button
    public void Quit()
    {
        Application.Quit();
    }
}
