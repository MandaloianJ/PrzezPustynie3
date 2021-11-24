using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{

     double numberOfBoxes =0;
    public Text counterView;
    public Text counterView2;

    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
    }
    public void IncrementCounter()
    {
        Debug.LogError("numberOfBoxes:" + numberOfBoxes);
        numberOfBoxes = numberOfBoxes+ 1;
        counterView.text = numberOfBoxes.ToString();
    }
    public void ResetCounter()
    {
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
