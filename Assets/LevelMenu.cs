using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] GameObject LevelUI, MainUI;
    public void OpenLevel(int level)
    {
        string levelname = "Level"+ " " + level;
        SceneManager.LoadScene(levelname);
        LevelUI.SetActive(false);
        MainUI.SetActive(true);
    }
}
