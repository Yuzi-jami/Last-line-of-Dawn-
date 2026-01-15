using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chararctermovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private SpriteRenderer sr;
    private Animator anim;

    private float dirX = 0f;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float  JumpSpeed= 7f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         dirX = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(dirX * moveSpeed, rb2d.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, JumpSpeed);
        }
        UpdateAnimationState();
        
    }

    private void UpdateAnimationState()
    {
        if (dirX > 0)
        {
            anim.SetBool("IsRun", true);
            sr.flipX = false; 
        }
        else if (dirX < 0)
        {
            anim.SetBool("IsRun", true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool("IsRun", false);
        }
        
    }
}
