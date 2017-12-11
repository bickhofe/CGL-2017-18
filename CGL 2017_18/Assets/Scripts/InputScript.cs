using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {

    public float speed = 1.5f;
    public Vector3 rotAngle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //transform.Rotate(rotAngle * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("up");
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //transform.Rotate(Vector3.up * speed * Time.deltaTime);
            //transform.localScale = new Vector3(.1f, .1f, .1f);
            //transform.eulerAngles = new Vector3(0,45,0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
