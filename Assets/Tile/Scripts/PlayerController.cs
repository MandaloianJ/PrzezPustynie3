using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///[RequireComponent(typeof(IdzwPrawo))]
public class PlayerController : MonoBehaviour
{
    public IdzwPrawo IdzwPrawo_skrypt;


    public float heroSpeed;
    public float jumpForce;
    public Transform groundTester;

    public LayerMask layearsToTest;
    Animator anim;
    Rigidbody2D rgdBody;
    bool dirToRight = true;

    public Transform startPoint;//kamil dodal

    public AudioClip clip;

    private bool onTheGround;
    private float radius = 0.1f;

    void Start() {

        anim = GetComponent<Animator>();
        rgdBody = GetComponent<Rigidbody2D>();
    }

    
    // Update is called once per frame
    void Update()
    {
        //onTheGround = Physics2D.OverlapCircle(groundTester.position, radius, layearsToTest);
        onTheGround = Physics2D.OverlapCircle(groundTester.position, radius, layearsToTest);

        float horizontalMove = Input.GetAxis("Horizontal");

        if (IdzwPrawo_skrypt.nacisniety_wlewo)
        {
            Debug.Log("PlayerController IsPressed called.");
            horizontalMove = 1f;
        }
        
        
        //Debug.Log("horizontalMove:" + horizontalMove);

        rgdBody.velocity = new Vector2 (horizontalMove * heroSpeed, rgdBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && onTheGround) {
            rgdBody.AddForce(new Vector2(0f, jumpForce)) ;
            anim.SetTrigger("jump") ;

            
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }

        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        //anim.SetFloat("speed", horizontalMove);

        if (horizontalMove < 0 && dirToRight)
        {
            Flip();
        }

        if (horizontalMove > 0 && !dirToRight)
            Flip();

    }

    void Flip()
    {
        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }

    public void idzwlewo()
    {
        //OpenLevel(currentLevel);
        Debug.Log("idz w lewo");
    }

    public void idzwprawo()
    {
        //OpenLevel(currentLevel);
        Debug.Log("idz w prawo");

        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }
    public void skacz()
    {
        //OpenLevel(currentLevel);
        Debug.Log("skacz");
    }
}

