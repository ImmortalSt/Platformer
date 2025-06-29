using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HPReGame : MonoBehaviour
{
    public int hpRes;
   

    public void GetHP(int hp)
    {
        PlayerHP playerHP = GetComponent<PlayerHP>();
        if (playerHP != null)
        {
            playerHP.GetHP(hpRes);
            
        }
    }

}
