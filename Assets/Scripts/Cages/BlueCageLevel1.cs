using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCageLevel1 : MonoBehaviour
{
    [SerializeField] GameObject zombieSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "brownCage")
        {
            Destroy(gameObject);
            CheckWin.CheckBrown();
            zombieSprite.SetActive(true);
        }
    }
}
