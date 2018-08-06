using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : Controller {

	public Animator an;
	public SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		an = GetComponent<Animator>();
		sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
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
            pawn.Jump();
			an.Play("Jump");
		}
	}
}
