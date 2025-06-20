using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventalManager : MonoBehaviour
{
    [SerializeField] private uint itemCount = 0;
    public static InventalManager Instance { get; private set; }

    private void Start()
    {
        Instance = this;
    }

    public void AddItem()
    {
        itemCount++;

    }

}
