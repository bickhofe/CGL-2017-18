using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

    public float force = 20.0f;
    Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	void Update () {
        //move
        if (Input.GetKey(KeyCode.UpArrow))    rb.AddForce(Vector3.forward * force);
        if (Input.GetKey(KeyCode.DownArrow))  rb.AddForce(Vector3.back * force);
        if (Input.GetKey(KeyCode.LeftArrow))  rb.AddForce(Vector3.left * force);
        if (Input.GetKey(KeyCode.RightArrow)) rb.AddForce(Vector3.right * force);

        //jump
        if (Input.GetKey(KeyCode.Space)) rb.AddForce(Vector3.up * force);  
    }

    void OnCollisionEnter(Collision collision)
    {
        print("hit: "+collision.gameObject.name);
    }

    //trigger
    void OnTriggerEnter(Collider collider)
    {
        print("Enter: " + collider.gameObject.name);
    }

    void OnTriggerStay(Collider collider)
    {
        print("Stay: " + collider.gameObject.name);
    }

    void OnTriggerExit(Collider collider)
    {
        print("Exit: " + collider.gameObject.name);
    }

}
