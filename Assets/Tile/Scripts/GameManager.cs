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
        if (PlayerPrefs.HasKey("currentLevel"))
        {
            currentLevel = PlayerPrefs.GetInt("currentLevel");
        }
    }
    
    public void OpenLevel(int newLevelNum)
    {

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
