using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearPlayerPrefs : MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.DeleteAll();
            print("all scores cleared!");
        }
	}

    public void Clear()
    {
        PlayerPrefs.DeleteAll();
        //PlayerPrefs.DeleteKey("Score");
        print("all scores cleared!");
    }
}
