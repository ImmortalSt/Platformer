using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentAttack : MonoBehaviour
{
    [SerializeField] private float HP = 100f;
    [SerializeField] private float distance = 1f;

    private void OnTriggerEnter2D(Collider2D attack)
    {
        if (attack.CompareTag("Player"))
        {
            PlayerHP playerHP = attack.GetComponent<PlayerHP>();
            if (playerHP != null) 
            {
                RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, Vector3.down, distance);
                foreach (var hit in hits)
                {
                    if (hit.collider != null && hit.collider.gameObject.layer == LayerMask.NameToLayer("dragon"))
                    {
                        float damage = 20f;
                        HP -= damage;
                        if (HP <= 0f)
                        {
                            playerHP.GetDamage(damage);
                            
                            Destroy(attack.gameObject); // ”ничтожить текущий объект 
                            break;
                        }
                        Debug.Log(" - 20. itog = " + HP);
                        playerHP.DeleteHP(damage);
                    }
                }
                //else if (attack.gameObject.layer == LayerMask.NameToLayer("fire"))
                //{
                //    HP -= 50f;
                //    Debug.Log(" - 50. itog = " + HP);
                //    if (HP <= 0f)
                //    {
                //        if (playerHP != null)
                //        {
                //            playerHP.GetDamage(50f);
                //        }
                //        Destroy(attack.gameObject); // ”ничтожить текущий объект
                //    }
                //}
            }
        }


    }   
}
