using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDevice : MonoBehaviour
{
    [SerializeField] private OpenDoor openDoor;
    [SerializeField] private ShowDragon showDragon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //openDoor.Open();
            showDragon.Open();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //openDoor.Close();
            showDragon.Close();
        }

    }

    
}
