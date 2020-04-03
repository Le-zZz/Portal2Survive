using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    bool isDeadP1 = false;
    bool isDeadP2 = false;

    [SerializeField] GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }
    void Update()
    {
        if (isDeadP1 && isDeadP2)
        {
            gameOverPanel.SetActive(true);
        }
        else
        {
            gameOverPanel.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            isDeadP1 = false;
        }

        if (collision.gameObject.tag == "player1")
        {
            isDeadP2 = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player2")
        {
            isDeadP1 = true;
        }

        if (collision.gameObject.tag == "player2")
        {
            isDeadP2 = true;
        }
    }
}
