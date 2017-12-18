using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WritePlayerPrefs : MonoBehaviour {

    public void WriteName(string playername)
    {
        PlayerPrefs.SetString("Playername", playername);
    }

    public void WriteScore(int score)
    {
        PlayerPrefs.SetInt("Score", score);
    }
}
