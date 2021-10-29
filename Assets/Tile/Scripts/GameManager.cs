using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int currentLevel = 0;

    public string[] levelNames;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
     
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("before PlayerPrefs currentLevel:" + currentLevel);
        currentLevel = 0;

        if (PlayerPrefs.HasKey("currentLevel"))
        {
            
            //currentLevel = PlayerPrefs.GetInt("currentLevel");
            //Debug.Log("PlayerPrefs currentLevel:" + currentLevel);
        }
    }
    
    public void OpenLevel(int newLevelNum)
    {
        //SceneManager.LoadScene("level1");
        SceneManager.LoadScene(levelNames[newLevelNum]);
    }

    public void OpenCurrentLevel()
    {
        OpenLevel(currentLevel);
    }

    public void CloseApplication()
    {
        PlayerPrefs.SetInt("currentLevel", currentLevel);

        Application.Quit();
    }

}
