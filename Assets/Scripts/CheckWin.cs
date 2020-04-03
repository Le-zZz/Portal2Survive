using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{

    static int normalRedDead = 0;
    static int normalBrownDead = 0;
    static int headlessRedDead = 0;
    static int headlessBrownDead = 0;
    static int bloodyRedDead = 0;
    static int bloodyBrownDead = 0;

    [SerializeField] static int normalRedNeeded = 0;
    [SerializeField] static int normalBrownNeeded = 0;
    [SerializeField] static int headlessRedNeeded = 0;
    [SerializeField] static int headlessBrownNeeded = 0;
    [SerializeField] static int bloodyRedNeeded = 0;
    [SerializeField] static int bloodyBrownNeeded = 0;

    [SerializeField] GameObject winPanel;

    private void Start()
    {
        winPanel.SetActive(false);
    }

    private void Update()
    {
        //if (normalBrownDead >= normalBrownNeeded
        //    && normalRedDead >= normalRedNeeded
        //    && headlessBrownDead >= headlessBrownNeeded
        //    && headlessRedDead >= headlessRedNeeded
        //    && bloodyBrownDead >= bloodyBrownNeeded
        //    && bloodyRedDead >= bloodyRedNeeded)
        if (normalRedDead == 1 && normalBrownDead == 1)
        {
            winPanel.SetActive(true);
        }

    }

    public static void CheckNormalRed()
    {
        normalRedDead++;
        Debug.Log(normalRedDead);
    }
    public static void CheckNormalBrown()
    {
        normalBrownDead++;
        Debug.Log(normalBrownDead);
    }
    public static void CheckHealdessRed()
    {
        headlessRedDead++;
        Debug.Log(headlessRedDead);
    }
    public static void CheckHealdessBrown()
    {
        headlessBrownDead++;
        Debug.Log(headlessBrownDead);
    }
    public static void CheckBloodyRed()
    {
        bloodyRedDead++;
        Debug.Log(bloodyRedDead);
    }
    public static void CheckBloodyBrown()
    {
        bloodyBrownDead++;
        Debug.Log(bloodyBrownDead);
    }
}
