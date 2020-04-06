using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownCageLevel1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "brownCage")
        {
            Destroy(gameObject);
            CheckWin.CheckBrown();
        }
    }
}
