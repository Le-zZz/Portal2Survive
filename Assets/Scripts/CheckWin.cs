using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    static int redDead = 0;
    static int brownDead = 0;
    static int redNeeded = 1;
    static int brownNeeded = 1;

    [SerializeField] GameObject winPanel;

    private void Start()
    {
        winPanel.SetActive(false);
    }

    private void Update()
    {
        if (redDead == redNeeded && brownDead == brownNeeded)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public static void CheckRed()
    {
        redDead++;
    }

    public static void CheckBrown()
    {
        brownDead++;
    }  
}
