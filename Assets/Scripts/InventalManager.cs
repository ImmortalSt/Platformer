using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventalManager : MonoBehaviour
{
    [SerializeField] private uint itemCount = 0;
    [SerializeField] private TMP_Text textCount;
    [SerializeField] private uint attackCount = 0;
    [SerializeField] private TMP_Text textAttackCount;

    public static InventalManager Instance { get; private set; }
    public static InventalManager InstanceAttack { get; private set; }

    private void Awake()
    {
        Instance = this;
        InstanceAttack = this;
    }

    public void AddItem()
    {
        itemCount++;
        textCount.text = $"Собрано: {itemCount}";
    }

    public void AddAttack()
    {
        PlayerAttack playerAttack = FindObjectOfType<PlayerAttack>();
        if (playerAttack != null && playerAttack.GetHP_opponent() <= 0)
        {
            attackCount++;
            if (textAttackCount != null)
            {
                textAttackCount.text = $"Уничтожено: {attackCount}";
            }
        }
    }
       
}
