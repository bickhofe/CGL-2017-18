using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPlayerPrefs : MonoBehaviour {

    public TextMesh TextfieldScore;

    void Start()
    {
        TextfieldScore.text = "Your score (with PlayerPrefs):\n"+ PlayerPrefs.GetInt("Score");
    }

}
