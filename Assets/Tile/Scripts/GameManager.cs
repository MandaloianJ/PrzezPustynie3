using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int currentLevel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance =this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenLevel(int newLeveNum)
    {
        
        //SceneManager.LoadScene
    }


    
}
