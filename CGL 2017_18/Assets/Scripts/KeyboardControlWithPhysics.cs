using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControlWithPhysics : MonoBehaviour {

    public float force = 5.0f;
    public Rigidbody rb;
	
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("up");
            rb.AddForce(Vector3.forward * force);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            print("down");
            rb.AddForce(Vector3.back * force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("left");
            rb.AddForce(Vector3.left * force);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("right");
            rb.AddForce(Vector3.right * force);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("space");
            rb.AddForce(Vector3.forward * force);
        }
    }
}
