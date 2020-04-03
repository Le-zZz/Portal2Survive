using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombieRed : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cageNormalRed")
        {
            Destroy(gameObject);
            CheckWin.CheckNormalRed();
        }
    }
}
