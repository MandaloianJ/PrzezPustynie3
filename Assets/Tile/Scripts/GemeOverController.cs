using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemeOverController : MonoBehaviour
{
    public GameObject successPanel;
    public GameObject failPanel;
    public GameObject GameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GameOverCanvas = GameObject.Find("Canvas");
        if (GameOverCanvas != null)
        {
            failPanel = GameOverCanvas.transform.GetChild(0).gameObject;
            successPanel = GameOverCanvas.transform.GetChild(1).gameObject;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "koniec")
        {
            Debug.Log("Sukces!");
            successPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if (other.gameObject.tag == "bariera")
        {
            Debug.Log("Porażka.");
            failPanel.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
