using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public float playerMoveSpeed;
	public float jumpHeight;

	// Use this for initialization
	void Awake () {
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
