using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTransmitter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenCurrentLevel()
    {
        Debug.Log("GameManager.instance.OpenLevel:" + GameManager.instance.currentLevel);
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        //Debug.Log("GameManager.instance.OpenLevel 1.");
        //GameManager.instance.OpenLevel(1);
        //SceneManager.LoadScene("level1");
    }

    public void CloseApplication()
    {
        PlayerPrefs.SetInt("currentLevel", GameManager.instance.currentLevel);

        Application.Quit();
    }
}
