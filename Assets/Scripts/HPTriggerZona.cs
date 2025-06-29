using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPTriggerZona : MonoBehaviour
{
    public int hpRes = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HPReGame hpReGame = collision.GetComponent<HPReGame>();
            if (hpReGame != null)
            {
                hpReGame.GetHP(hpRes);
            }
        }
    }
}
