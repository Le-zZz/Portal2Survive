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

    private void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (isDeadP1 && isDeadP2)
        {
            gameOverPanel.SetActive(true);
            isGameOver = true;
            Time.timeScale = 0f;
        }

        if (isGameOver)
        {
            deathPanelP1.SetActive(false);
            deathPanelP2.SetActive(false);
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
    }
}
