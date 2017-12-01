using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour {

    public float speed = 5.0f;
	
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow pressed!");
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Up arrow pressed!");
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Up arrow pressed!");
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Up arrow pressed!");
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("Up arrow pressed!");
        //    transform.Translate(Vector3.up * speed * Time.deltaTime);
        //}
    }
}
