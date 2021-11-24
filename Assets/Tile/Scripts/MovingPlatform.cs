﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Transform navStartPoint;
    public Transform navEndPoint;

    private Vector2 startPoint;
    private Vector2 endPoint;
    public float speed;

    private Vector2 currentPlatformPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = navStartPoint.position;
        endPoint = navEndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {

        currentPlatformPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;
        //Destroy (navStartPoint.gameObject);
        //Destroy (navEndPoint.gameObject);

        //transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);
        //transform.Translate(speed, 0, 0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log (other.gameObject.name);
        other.transform.parent = transform;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name + " - OUT");
        other.transform.parent = null;
    }

}
