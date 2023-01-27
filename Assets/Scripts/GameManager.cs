using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text textScore;

    [SerializeField]
    TMP_Text textCountdown;

    [SerializeField]
    GameObject gameOver;


    [SerializeField]
    float gameDuration;

    float remainingTime;

    int score;


    void Start()
    {
        textScore.text = "Score: " + 0;
    }

  
    void Update()
    {

        if(remainingTime >=0 )
        {
            remainingTime = gameDuration - Time.time;
            textCountdown.text = "Countdown: " + remainingTime;
        }
        else
        {
            gameOver.SetActive(true);
        }

    }

    public void AddtoScore()
    {
        score = score + 1;
        textScore.text = "Score: " + score.ToString();
    }


}
