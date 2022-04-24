using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GluttonyPlayer : MonoBehaviour
{
    private Rigidbody2D rigidbody2;
    private Animator animator;
    private SpriteRenderer SRenderer;

    private float spped = 5;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        SRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        //Debug.Log("Input : " + horizontal);
        PlayerMove();
        ScreenChk();
    }

    private void PlayerMove()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        if(horizontal < 0)
        {
            SRenderer.flipX = true;
        }
        else
        {
            SRenderer.flipX = false;
        }
        rigidbody2.velocity = new Vector2(horizontal * spped, rigidbody2.velocity.y);
        
    }

    private void ScreenChk()
    {
        Vector3 worlpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if(worlpos.x < 0.02f) worlpos.x = 0.02f;
        if(worlpos.x > 0.98f) worlpos.x = 0.98f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worlpos);
    }

}
