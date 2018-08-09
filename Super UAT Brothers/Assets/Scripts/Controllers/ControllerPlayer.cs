using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : Controller {

    public LayerMask ground;
    public GameObject groundCheck;
    public float groundCheckRadius;
    public bool grounded;
    public AudioClip jumpSound;
    public AudioClip deathSound;
    public AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.OverlapCircle(groundCheck.transform.position, groundCheckRadius, ground);

		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			pawn.MoveLeft();
		}
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			pawn.MoveRight();
		}
        if(Input.GetKeyDown(KeyCode.Space))
        {
			if (GameManager.instance.numofJumps < 1)
            {
                audio.PlayOneShot(jumpSound);
                ++GameManager.instance.numofJumps;
                pawn.Jump();
            }
            
		}
        if (grounded)
        {
            GameManager.instance.numofJumps = 0;
        }
	}
}
