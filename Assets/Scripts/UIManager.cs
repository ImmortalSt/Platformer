using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Button menuBtn;

    void Start()
    {
        if(menuBtn == null)
        {
            return;
        }
        menuBtn.onClick.AddListener(OpenMenu);

    }

    private void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }

}
