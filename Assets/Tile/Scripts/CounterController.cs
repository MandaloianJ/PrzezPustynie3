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
    DateTime czas_ostatniego_zebrania_monety;
    

    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
        czas_ostatniego_zebrania_monety = DateTime.Now;
    }
    public void IncrementCounter()
    {
        Debug.LogError("numberOfBoxes:" + numberOfBoxes);

        if ((DateTime.Now - czas_ostatniego_zebrania_monety).TotalMilliseconds > 250)
        {
            numberOfBoxes = numberOfBoxes + 1;
            counterView.text = numberOfBoxes.ToString();
            czas_ostatniego_zebrania_monety = DateTime.Now;
        }
        
    }
    public void ResetCounter()
    {
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
