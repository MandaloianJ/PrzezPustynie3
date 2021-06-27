using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus: MonoBehaviour {

    public Transform startPoint;
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            other.transform.position = startPoint.position;
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
