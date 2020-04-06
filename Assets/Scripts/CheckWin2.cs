using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin2 : MonoBehaviour
{

    static int redDead = 0;
    static int brownDead = 0;


    static int redNeeded = 2;
    static int brownNeeded = 2;


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
