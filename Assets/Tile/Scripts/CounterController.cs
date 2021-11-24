using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CounterController : MonoBehaviour
{

     double numberOfBoxes =0;
    public Text counterView;
    public Text counterView2;
    DateTime lastevent;
    

    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
        lastevent = DateTime.Now;
    }
    public void IncrementCounter()
    {
        Debug.LogError("numberOfBoxes:" + numberOfBoxes);

        if ((DateTime.Now - lastevent).TotalMilliseconds > 250)
        {
            numberOfBoxes = numberOfBoxes + 1;
            counterView.text = numberOfBoxes.ToString();
            lastevent = DateTime.Now;
        }
        
        
    }
    public void ResetCounter()
    {
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
