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

    //[SerializeField] private float minX = -5f;
    //[SerializeField] private float maxX = 5f;
    //public Transform target;
    //public float smoothTime = 0.2f;

    //private Vector3 _velocity = Vector3.zero;

    //void LateUpdate()
    //{
    //    Vector3 targetPosition = new Vector3(
    //        target.position.x < minX
    //        ? minX
    //        : (target.position.x > maxX
    //        ? maxX
    //        : target.position.x), target.position.y, transform.position.z);

    //    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, smoothTime);
    //}

}
