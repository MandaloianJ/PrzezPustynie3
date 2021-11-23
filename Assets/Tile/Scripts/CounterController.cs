using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{

     int numberOfBoxes =0;
    public Text counterView;
    public Text counterView2;

    // Start is called before the first frame update
    void Start()
    {
        counterView.text = numberOfBoxes.ToString();
    }
    public void IncrementCounter()
    {
        numberOfBoxes++;
        counterView.text = numberOfBoxes.ToString();
    }
    public void ResetCounter()
    {
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
