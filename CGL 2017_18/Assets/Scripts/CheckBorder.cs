using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBorder : MonoBehaviour {

    public float speed = 5.0f;

    float xPos;
    float yPos;
    float zPos;

	void Update () {

        //move
        if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right * speed * Time.deltaTime);

        //check border
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;

        if (xPos < -4) xPos = -4;
        if (xPos >  4) xPos =  4;
        if (zPos < -4) zPos = -4;
        if (zPos >  4) zPos =  4;

        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
