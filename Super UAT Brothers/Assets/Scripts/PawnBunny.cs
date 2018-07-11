using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnBunny : MonoBehaviour {

    public Transform tf;
    public Rigidbody2D rb;
    public Animator an;
    public SpriteRenderer sr;

    public bool isGroundedDistance;
    public float groundedDistance;

	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();
        rb = GetComponent<Transform>();
        an = GetComponent<Transform>();
        sr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        CheckForGrounded();
	}

    public void CheckForGrounded()
    {
        RaycastHit2D hitInfo; //creates a variable to hold info about raycast hit
        hitInfo = Physics2D.Raycast(tf.position, Vector2.down, groundedDistance);
        if (hitInfo.collider.gameObject.tag == "Ground")
    }
}
