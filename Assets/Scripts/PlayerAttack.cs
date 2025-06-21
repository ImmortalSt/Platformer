using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float distance = 1f;
    [SerializeField] private float HP_opponent = 100f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // пусть луч
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, Vector3.down, distance);

            // проверть попал ли луч в объект с Distoy.Tag
            foreach (var hit in hits)
            {
                if (hit.collider.CompareTag("Destroy"))
                {
                    if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Box"))
                    {
                        HP_opponent -= 10f;
                        Debug.Log(" - 10. itog = " + HP_opponent);
                        if (HP_opponent <= 0f)
                        {
                            InventalManager.InstanceAttack.AddAttack();
                            Destroy(hit.collider.gameObject); // уничтожить / нанести урон
                            break;
                        }
                    }
                    else if (hit.collider.gameObject.layer == LayerMask.NameToLayer("BoxMetall"))
                    {
                        HP_opponent -= 50f;
                        Debug.Log(" - 50. itog = " + HP_opponent);
                        if (HP_opponent <= 0f)
                        {
                            InventalManager.InstanceAttack.AddAttack();
                            Destroy(hit.collider.gameObject); // уничтожить / нанести урон
                            break;
                        }
                    }
                }
            }
        }

    }

    public float GetHP_opponent()
    {
        return HP_opponent;
    }
}
