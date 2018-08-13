using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winBarrier : MonoBehaviour {

	public GameObject nextLevel;
	public GameObject currentLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "player")
		{
			currentLevel.SetActive(false);
			nextLevel.SetActive(true);
			other.gameObject.transform.position = new Vector3(0, 0, 0);
			other.gameObject.GetComponent<PawnPlayer>().startPosition = new Vector3(0, 0, 0);
		}
	}
}
