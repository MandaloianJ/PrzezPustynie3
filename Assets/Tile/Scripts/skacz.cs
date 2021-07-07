using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skacz : Button
{

    public bool nacisniety_skacz = false;

    public void Update()
    {
        nacisniety_skacz = IsPressed();
        //if (IsPressed())
        //{
        //    onClick.Invoke();
        //    Debug.Log("IsPressed called.");
        //}
    }


}