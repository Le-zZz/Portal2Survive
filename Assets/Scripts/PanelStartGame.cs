using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelStartGame : MonoBehaviour
{
    [SerializeField] private GameObject panelStartGame;

    private void Start()
    {
        ActivatePanel();
    }

    public void ActivatePanel()
    {
        panelStartGame.SetActive(true);
        Time.timeScale = 0f;
    }

    public void DeactivatePanel()
    {
        panelStartGame.SetActive(false);
        Time.timeScale = 1f;
    }
}
