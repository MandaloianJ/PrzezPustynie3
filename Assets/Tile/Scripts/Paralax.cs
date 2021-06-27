using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public Transform cameraTranform;
    public float Parallaxfactor;

    private Vector3 prevCameraPosition;
    private Vector3 deltaCameraPosition;

    
    // Start is called before the first frame update
    void Start()
    {

        prevCameraPosition = cameraTranform.position;

    }

    // Update is called once per frame
    void Update()
    {

        deltaCameraPosition = cameraTranform.position - prevCameraPosition;
        Vector3 parallaxPosition = new Vector3(transform.position.x + (deltaCameraPosition.x * Parallaxfactor), transform.position.y, transform.position.x);
        transform.position = parallaxPosition;
        prevCameraPosition = cameraTranform.position;
    }
}
