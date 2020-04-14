using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    bool isDeadP1 = false;
    bool isDeadP2 = false;
    bool isGameOver = false;

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject deathPanelP1;
    [SerializeField] GameObject deathPanelP2;

    void Update()
    {

        if (isGameOver)
        {
            deathPanelP1.SetActive(false);
            deathPanelP2.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        if (isDeadP1 && isDeadP2)
        {
            gameOverPanel.SetActive(true);
            isGameOver = true;
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            isDeadP1 = true;
        }

        if (collision.gameObject.tag == "player2")
        {
            isDeadP2 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isDeadP1 = false;
        isDeadP2 = false;
        Time.timeScale = 1f;
    }
}
