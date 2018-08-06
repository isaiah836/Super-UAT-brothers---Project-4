using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    public Animator an;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    // Use this for initialization
    void Start () {
        an = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (rb.velocity.y > 0.1f)
        {
            an.Play("Jump");
            sr.flipX = false;
        }
        else if (rb.velocity.x > 0.1f)
        {
            an.Play("Player_WalkAnimation");
            sr.flipX = false;
        }
        else if (rb.velocity.x < -0.1f)
        {
            an.Play("Player_WalkAnimation");
            sr.flipX = true;
        }
        else if (rb.velocity.x == 0)
        {
            an.Play("Idle_Animation");
        }
	}
}
