using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] GameObject LevelUI,MainUI,PlayerUI;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LevelSelection()
    {
        MainUI.gameObject.SetActive(false);
        LevelUI.gameObject.SetActive(true);
    }
    public void HomeSelection()
    {
        MainUI.gameObject.SetActive(true);
        LevelUI.gameObject.SetActive(false);
    }
    public void PlayerSelection()
    {
        MainUI.gameObject.SetActive(false);
        PlayerUI.gameObject.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
