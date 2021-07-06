using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IdzwPrawo : Button
{
    public bool nacisniety_wlewo = false;

    public void Update()
    {
        nacisniety_wlewo = IsPressed();
        if (IsPressed())
        {
            //onClick.Invoke();
            Debug.Log("IsPressed called.");
        }
    }


}