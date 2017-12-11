using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPill : MonoBehaviour {

    public float force = 20.0f;
    Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	void FixedUpdate () {
        //move
        if (Input.GetKey(KeyCode.UpArrow))    rb.AddForce(Vector3.forward * force * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))  rb.AddForce(Vector3.back * force * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))  rb.AddForce(Vector3.left * force * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow)) rb.AddForce(Vector3.right * force * Time.deltaTime);
    }

    //trigger
    void OnTriggerEnter(Collider collider)
    {
        print("Enter: " + collider.gameObject.name);

        //if (collider.gameObject.name == "Pill")
        //{
        //    Destroy(collider.gameObject);
        //}

        if (collider.gameObject.tag == "Pill")
        {
            print("Pill collected");
            Destroy(collider.gameObject);
        }
    }


}
