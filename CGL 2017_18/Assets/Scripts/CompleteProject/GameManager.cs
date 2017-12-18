using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text TextfieldTime;
    public Text TextfieldScore;

    public float gameTime = 10.0f;
    float time = 0;
    public int score = 0;
    public float endGameDelay = 3.0f;
    public GameObject TxtGameOver;
    public bool gameOver = false;

    void Start()
    {
        TxtGameOver.SetActive(false);

        //spawn pill
        GetComponent<SpawnObject>().SpawnPill();
    }

    // Update is called once per frame
    void Update () {
        if (time < gameTime)
        {
            TextfieldTime.text = "Time: " + (time += Time.deltaTime).ToString("00:00");
            TextfieldScore.text = "Score: " + score;
        } else
        {
            if (!gameOver)
            {
                //fire only once
                gameOver = true;

                //game over text
                TxtGameOver.SetActive(true);

                //access othet scripts and write score
                if (score > PlayerPrefs.GetInt("Score")) GetComponent<WritePlayerPrefs>().WriteScore(score);

                //delay
                Invoke("GameOver", endGameDelay);
            }   
        }
    }

    void GameOver()
    {
        //access othet script
        GetComponent<LoadNewScene>().LoadScene("Result");
    }
}
