using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    public Animator an;
    public RigidBody2D rb;

    // Use this for initialization
    void Start () {
        an = GetComponent<Animator>();
        rb = GetComponent<RigidBody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (rb.velocity.)
	}
}
