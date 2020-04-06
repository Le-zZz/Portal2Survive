using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("Level_1");
        Time.timeScale = 1f;
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level_2");
        Time.timeScale = 1f;
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level_3");
        Time.timeScale = 1f;
    }
}
