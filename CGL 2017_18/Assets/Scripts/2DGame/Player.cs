using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;
    public float jumpForce = 10;
    float move;
    public float speed = 2;
    public bool isFalling;
    public Animator Anim;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxis("Horizontal");
        Anim.SetFloat("speed", rb.velocity.x);
        print(rb.velocity.y);
        if (rb.velocity.y <= 0) isFalling = true;
        else isFalling = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // if (collision.relativeVelocity.y >= 0) rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        if (isFalling) rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void FixedUpdate()
    {
        //rb.AddForce(Vector2.right * move * speed * Time.deltaTime);

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }
}
