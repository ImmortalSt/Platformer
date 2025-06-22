using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentAttack : MonoBehaviour
{
    [SerializeField] private float damage = 20f;

    private void OnTriggerEnter2D(Collider2D playerCollider)
    {
        if (playerCollider.CompareTag("Player"))
        {
            PlayerHP playerHP = playerCollider.GetComponent<PlayerHP>();
            if (playerHP != null)
            {
                playerHP.GetDamage(damage);
            }
        }
    }   
}
