using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDevice : MonoBehaviour
{
    [SerializeField] private OpenDoor openDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            openDoor.Open();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            openDoor.Close();
        }

    }
}
