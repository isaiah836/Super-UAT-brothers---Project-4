using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPlayer : Pawn {

	private Transform tf;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
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
		Debug.Log("You Jumped");
	}
}
