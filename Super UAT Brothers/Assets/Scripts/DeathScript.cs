using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	public AudioSource audio;// grabs audi source
	public AudioClip heroDeath; // ghets clip used for when the player dies

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerExit2D(Collider2D other)
	{
		// if player falls out of bounds reset to checkPoint and play death sound
		if (other.gameObject.tag == "player")
		{
			audio.PlayOneShot(heroDeath);
			other.gameObject.transform.position = other.gameObject.GetComponent<PawnPlayer>().startPosition;
			--GameManager.instance.playerLives;
		}
	}
}
