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



public class ReactionTime : MonoBehaviour
{
    private float timeElapsed;
    public float reactionTime = 0;
    public List<double> reactionTimeList = new List<double>();
    public GameManager gameManager;
    public int sceneBuildIndexToLoad = 2;

    public float NeutralStimuli = 15f;
    public float ConStimuli = 20f;
    public float InconStimuli = 30f;

    public float delayBeforeLoading ;


    void Start()
    {
        delayBeforeLoading = NeutralStimuli + ConStimuli + InconStimuli;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        reactionTime += Time.deltaTime;

        if(timeElapsed<NeutralStimuli)
        {
            gameManager.state = 0;
        }
        else if (timeElapsed>=NeutralStimuli && timeElapsed<NeutralStimuli+ConStimuli)
        {
            gameManager.state = 1;
        }
        else if (timeElapsed>= NeutralStimuli+ConStimuli && timeElapsed<NeutralStimuli+ConStimuli+InconStimuli)
        {
            gameManager.state = 2;
        }
        else
        {
            Debug.Log("Avg reaction time: " + gameManager.reactionTimeList.Average());

            write_stats();

            //update_score();

            SceneManager.LoadScene("Transition");
        }
    }

    public void write_stats()
    {
        double[] myArray = gameManager.reactionTimeList.ToArray();

        string filename = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".json";

        stats_players _data = new stats_players();
        _data.Accuracy = gameManager.accuracy;
        _data.reaction = myArray;

        string json =  JsonUtility.ToJson(_data, true);
        File.WriteAllText(filename, json);
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

        json =  JsonUtility.ToJson(__data, true);
        File.WriteAllText("score.json", json);
    }
}
