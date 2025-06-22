using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    public float distance = 1.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Operate();
    }
    private void Operate()
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.right, distance);


        foreach (var hit in hits)
        {
            var device = hit.collider.GetComponent<OpenDoor>();
            if (device != null)
                device.Operate();
        }
    }

    // по радиусу открытие door

    //public float radius = 1.5f;

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //        Operate();
    //}
    //private void Operate()
    //{
    //    Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radius);

    //    foreach (var hit in hits)
    //    {
    //        var device = hit.GetComponent<DoorOpenDevice>();
    //        if (device != null)
    //            device.Operate();
    //    }
        //}

    
}
