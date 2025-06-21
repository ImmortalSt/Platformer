using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float HP = 100f;
    private bool isDead = false;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    public void GetDamage(float damage)
    {
        if (isDead) return;
        HP -= damage;
        if (HP <= 0)
        {
            isDead = true;
            HP = 0;
            Debug.Log("Player is dead");
            Respawn();
        }
    }

    //возродение игрока на начальной позиции
    private void Respawn()
    {
        transform.position = startPosition;
        HP = 100f;
        isDead = false;

        FollowCamera cam = FindObjectOfType<FollowCamera>();
        if (cam != null)
        {
            cam.target = transform;
        }
    }
}
