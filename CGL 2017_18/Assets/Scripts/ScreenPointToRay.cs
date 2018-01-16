using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPointToRay : MonoBehaviour {
    RaycastHit hit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Construct a ray from the current mouse coordinates

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.name);
                //Debug.DrawLine(hit.point, debugrayend, Color.red);
                //Debug.Log(hit.point);
                //Instantiate (particle, hit.point, transform.rotation); // Create a particle if hit
            }
        }

    }
}
