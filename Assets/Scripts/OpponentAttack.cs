using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentAttack : MonoBehaviour
{
    [SerializeField] private float HP = 100f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHP playerHP = other.GetComponent<PlayerHP>();

        if (other.CompareTag("Player"))
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("dragon"))
            {
                HP -= 20f;
                Debug.Log(" - 20. itog = " + HP);
                if (HP <= 0f)
                {
                    if (playerHP != null)
                    {
                        playerHP.GetDamage(20f);
                    }
                    Destroy(other.gameObject); // ”ничтожить текущий объект
                }
            }
            else if (other.gameObject.layer == LayerMask.NameToLayer("fire"))
            {
                HP -= 50f;
                Debug.Log(" - 50. itog = " + HP);
                if (HP <= 0f)
                {
                    if (playerHP != null)
                    {
                        playerHP.GetDamage(50f);
                    }
                    Destroy(other.gameObject); // ”ничтожить текущий объект
                }
            }
        }


    }   
}
