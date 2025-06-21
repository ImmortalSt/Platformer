using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float HP = 100f;
    private bool isDead = false;
    private Vector3 startPosition;
      
    [SerializeField] private TMP_Text textHP;

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

    public void DeleteHP(float damage)
    {
        HP -= damage;
        textHP.text = $"HP: {HP}";
    }

    //возродение игрока на начальной позиции
    private void Respawn()
    {
        transform.position = startPosition;
        HP = 100f;
        isDead = false;
        textHP.text = $"HP: 100";
        FollowCamera cam = FindObjectOfType<FollowCamera>();
        if (cam != null)
        {
            cam.target = transform;
        }
    }
}
