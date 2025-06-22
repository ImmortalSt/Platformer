using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    [SerializeField] private Vector2 dPos;
    private bool _open;

    public void Operate()
    {
        if (_open)
            Open();
        else
            Close();
    }

    public void Open()
    {
        if (!_open)
        {
            transform.position += (Vector3)dPos;
            _open = true;
        }
    }

    public void Close()
    {
        if (_open)
        {
            transform.position -= (Vector3)dPos;
            _open = false;
        }
    }



}
