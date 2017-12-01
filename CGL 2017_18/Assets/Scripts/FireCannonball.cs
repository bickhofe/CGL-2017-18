using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannonball : MonoBehaviour {

    public GameObject Cannonball;
    public float CannonPower = 1000f;

	void Update () {

        //if (Input.GetMouseButton(0))
        //{
        //    Instantiate(Cannonball, transform.position + Vector3.forward * 1f, Quaternion.identity);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            GameObject NewCannonball = Instantiate(Cannonball, transform.position + Vector3.forward * 1f, Quaternion.identity);
            NewCannonball.GetComponent<Rigidbody>().AddForce(Vector3.forward * CannonPower);
        }

    }
}
