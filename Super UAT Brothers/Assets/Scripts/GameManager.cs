using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	[Header("Player Settings")]
	public GameObject Player;
	public float playerLives;
	public float playerMoveSpeed;
	public float jumpHeight;
	public float numofJumps;


	// Use this for initialization
	void Awake () {
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerLives < 1)
		{
			LoadScenes(3);
		}
	}

	public void LoadScenes(int scene)
	{
		SceneManager.LoadScene(scene);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
