using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour
{
    //public AnimationClip clip;
    CounterController counterController;
    // Start is called before the first frame update
    void Start()
    {
        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
        if (counterController == null)
        {
            Debug.LogError("nie znaleziono Counter Controler");
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            counterController.IncrementCounter();
            Destroy(this.gameObject);
            
        }
    }
}
