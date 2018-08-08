﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : Controller {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//RaycastHit2D hit2D = Physics2D
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
			if (GameManager.instance.numofJumps <= 2)
            pawn.Jump();
		}
	}
}
