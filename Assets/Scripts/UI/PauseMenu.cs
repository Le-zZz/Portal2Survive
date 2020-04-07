using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActivatePauseMenu();
        }
    }

    public void ActivatePauseMenu()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void DesactivatePanelMenu()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
