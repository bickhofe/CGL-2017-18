using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject Pill;
    public GameObject Enemy;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPill();
        }

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    Vector2 RandomPosition = Random.insideUnitCircle * 4;
        //    Instantiate(Enemy, new Vector3(RandomPosition.x, 0.5f, RandomPosition.y), Quaternion.identity);
        //}
    }

    public void SpawnPill()
    {
        Vector2 RandomPosition = Random.insideUnitCircle * 4;
        Instantiate(Pill, new Vector3(RandomPosition.x, 0.5f, RandomPosition.y), Quaternion.identity);
    }
}
