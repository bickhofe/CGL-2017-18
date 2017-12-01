using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, 5);
    }

    //trigger
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            print("Enemy hit");
            Destroy(collider.gameObject); // Enemy
            Destroy(gameObject); //Ball
        }
    }
}
