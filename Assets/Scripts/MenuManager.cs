using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button startBtn;
    [SerializeField] private Button exitBtn;

    private void Start()
    {
        if(startBtn == null ||exitBtn == null)
        {
            return;
        }
        startBtn.onClick.AddListener(StartGame);
        exitBtn.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
   

}
