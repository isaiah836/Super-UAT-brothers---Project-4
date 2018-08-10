using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPlayer : Pawn {

	private Transform tf;
    private Rigidbody2D rb;
	public Vector3 startPosition;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void MoveLeft()
	{
		tf.position += Vector3.left * GameManager.instance.playerMoveSpeed * Time.deltaTime;
	}

	public override void MoveRight()
	{
		tf.position += Vector3.right * GameManager.instance.playerMoveSpeed * Time.deltaTime;
	}
	public override void Jump()
	{
        rb.velocity = Vector3.up * GameManager.instance.jumpHeight;
	}
}
