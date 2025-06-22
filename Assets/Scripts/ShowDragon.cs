using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDragon : MonoBehaviour
{
    [SerializeField] private Vector2 dPos;
    private bool _show;
    public Transform target;

    public void Operate()
    {
        if (_show)
            Open();
        else
            Close();
    }

    public void Open()
    {
        if (!_show)
        {
            Vector3 dragonPosition;
            if (target != null)
            {
                dragonPosition = new Vector3(target.position.x, target.position.y + dPos.y, target.position.z);
            }
            else
            {
                dragonPosition = new Vector3(transform.position.x, transform.position.y + dPos.y, transform.position.z);
            }
            transform.position = dragonPosition;
            _show = true;
        }
    }

    public void Close()
    {
        if (_show)
        {
            Vector3 dragonPosition;
            if (target != null)
            {
                dragonPosition = new Vector3(target.position.x, target.position.y - dPos.y, target.position.z);
            }
            else
            {
                dragonPosition = new Vector3(transform.position.x, transform.position.y - dPos.y, transform.position.z);
            }
            transform.position = dragonPosition;
            _show = false;
        }
    }
}

