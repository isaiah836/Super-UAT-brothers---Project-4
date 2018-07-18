using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStuff : MonoBehaviour {

    public AudioClip theClip;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = theClip;
        audioSource.Play();
        //audioSource.PlayOneShot();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
