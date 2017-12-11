using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePhys : MonoBehaviour {

    public Rigidbody rb;
    public float power = 100;
    public float jumpPower = 100;

    public bool isGrounded;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * power);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * jumpPower);
            if (isGrounded == true)
            {
                rb.velocity = new Vector3(0, jumpPower, 0);
                isGrounded = false;
            }
        }

        print(rb.velocity);
    }

    void OnCollisionEnter(Collision collision)
    {
        print("ground hit: " + collision.gameObject.name);
        isGrounded = true;
    }

    void OnCollisionStay(Collision collision)
    {
        print("grounded");
    }

    //void OnCollisionExit(Collision collision)
    //{
    //    print("hit: " + collision.gameObject.name);
    //}

}
