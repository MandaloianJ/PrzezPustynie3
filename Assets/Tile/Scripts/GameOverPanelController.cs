using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverPanelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void LoadLevelAgain()
    {
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }

    public void LoadNextLevel()
    {
        GameManager.instance.currentLevel++;
        if (GameManager.instance.currentLevel < GameManager.instance.levelNames.Length)
        {
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        }
        else
        {
            GameManager.instance.currentLevel = 0;
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Loadleve1()
    {
        SceneManager.LoadScene("level1");
    }
}
