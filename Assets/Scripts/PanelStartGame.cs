using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelStartGame : MonoBehaviour
{
    private bool pausedGame = false;
    [SerializeField] private GameObject panelStartGame;

    public GameObject StartGamePanel
    {
        get => panelStartGame;
        set => panelStartGame = value;
    }

    void Start()
    {
        ActivatePanel();
    }

    public void ActivatePanel()
    {
        StartGamePanel.SetActive(true);
        Time.timeScale = 0f;
        pausedGame = true;
    }

    public void DeactivatePanel()
    {
        StartGamePanel.SetActive(false);
        Time.timeScale = 1f;
        pausedGame = false;
    }
}
