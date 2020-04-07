using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string restartScene;
    
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 0f;
    }

    public void LoadPlayScene()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Level_1");
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

    public void Restart()
    {
        SceneManager.LoadScene(restartScene);
        Time.timeScale = 1f;
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
