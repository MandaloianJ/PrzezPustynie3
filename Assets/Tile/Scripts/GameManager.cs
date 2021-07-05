using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int currentLevel;

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
        
    }

    public void OpenLevel(int newLevelNum)
    {

        SceneManager.LoadScene(levelNames[newLevelNum]);
    }


    
}
