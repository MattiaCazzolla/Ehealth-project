using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;
using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

public class TimeManagerBonus : MonoBehaviour
{
    private float timeElapsed;
    public GameManager gameManager;

    public float delayBeforeLoading=20;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= delayBeforeLoading)
        {
            update_score();
            gameManager.score = 0;
            SceneManager.LoadScene("Menu");
        }
    }

    public void update_score()
    {
        string json = File.ReadAllText("score.json");
        score_stats __data = JsonUtility.FromJson<score_stats>(json);

        __data.TotScore += gameManager.score;

        if (__data.MaxScore < gameManager.score)
        {
            __data.MaxScore = gameManager.score;
        }

        json = JsonUtility.ToJson(__data, true);
        File.WriteAllText("score.json", json);
    }
}
