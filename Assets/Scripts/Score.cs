using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    static int normalRedDead = 0;
    static int normalBrownDead = 0;
    static int headlessRedDead = 0;
    static int headlessBrownDead = 0;
    static int bloodyRedDead = 0;
    static int bloodyBrownDead = 0;

    [SerializeField] int normalRedNeeded = 0;
    [SerializeField] int normalBrownNeeded = 0;
    [SerializeField] int headlessRedNeeded = 0;
    [SerializeField] int headlessBrownNeeded = 0;
    [SerializeField] int bloodyRedNeeded = 0;
    [SerializeField] int bloodyBrownNeeded = 0;

    [SerializeField] GameObject winPanel;

    private void Start()
    {
        winPanel.SetActive(false);
    }

    private void Update()
    {
        if (normalBrownDead >= normalBrownNeeded
            && normalRedDead >= normalRedNeeded
            && headlessBrownDead >= headlessBrownNeeded
            && headlessRedDead >= headlessRedNeeded
            && bloodyBrownDead >= bloodyBrownNeeded
            && bloodyRedDead >= bloodyRedNeeded)
        {
            winPanel.SetActive(true);
        }

    }

    public static void CheckNormalRed()
    {
        normalRedDead++;
    }
    public static void CheckNormalBrown()
    {
        normalBrownDead++;
    }
    public static void CheckHealdessRed()
    {
        headlessRedDead++;
    }
    public static void CheckHealdessBrown()
    {
        headlessBrownDead++;
    }
    public static void CheckBloodyRed()
    {
        bloodyRedDead++;
    }
    public static void CheckBloodyBrown()
    {
        bloodyBrownDead++;
    }
}
