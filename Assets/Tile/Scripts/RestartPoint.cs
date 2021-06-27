using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPoint : MonoBehaviour
{
    public AudioClip clip;
    RestartPointsManager restartPointsManager;
    SpriteRenderer sprRenderer;
    // Start is called before the first frame update
    void Start()
    {
        restartPointsManager = GameObject.Find("Manager").GetComponent<RestartPointsManager>();
        if (restartPointsManager == null)
        {
            Debug.LogError("restartPointsManager nie zoztał znaleziony.");
        }
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D( Collider2D other)
    {
       if (other.gameObject.tag == "Player") {
            restartPointsManager.UpdateStartPoint(this.gameObject.transform);
            sprRenderer.color = new Color(0.3f, 0.6f, 0.6f);
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
