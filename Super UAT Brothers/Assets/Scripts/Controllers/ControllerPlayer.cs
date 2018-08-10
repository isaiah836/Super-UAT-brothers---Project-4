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

	public SpriteRenderer sr;

	public bool isMove;
	public bool isFacingR;
	public bool isJump;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
		sr = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update() {
		grounded = Physics2D.OverlapCircle(groundCheck.transform.position, groundCheckRadius, ground);

		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			pawn.MoveLeft();
			isMove = true;
			sr.flipX = true;
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			pawn.MoveRight();
			isMove = true;
			sr.flipX = false;
		}
		if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
		{
			isMove = false;
		}
        if(Input.GetKeyDown(KeyCode.Space))
        {
			if (GameManager.instance.numofJumps < 1)
            {
                audio.PlayOneShot(jumpSound);
                ++GameManager.instance.numofJumps;
				isJump = true;
                pawn.Jump();
            }
            
		}
        if (grounded)
        {
            GameManager.instance.numofJumps = 0;
			isJump = false;
        }
	}
}
