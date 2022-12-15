using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using TMPro;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public float delayBeforeLoading = 30f;
    public int sceneBuildIndexToLoad;
    private float timeElapsed;

    public int state = 0;
    public int rand_state;
    public int score;
    public float accuracy;

    public float reactionTime = 0;
    public List<float> reactionTimeList = new List<float>();

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI matchText;
    private stimuli_spawner stimuli;

    void Start()
    {
        score = 0;
        stimuli = GameObject.Find("STIMULI").GetComponent<stimuli_spawner>();
    }


    private void Update()
    {
        timeElapsed += Time.deltaTime;
        reactionTime += Time.deltaTime;

        if(timeElapsed > delayBeforeLoading)
        {
            Debug.Log("Avg reaction time: " + reactionTimeList.Average());
            SceneManager.LoadScene(sceneBuildIndexToLoad);
        }

        if (state == 0)
            matchText.text = "Match Shape";
        else if (state == 1)
            matchText.text = "Match Color";
        else
        {
            if (stimuli.rand_state == 0)
                matchText.text = "Match Shape";
            else
                matchText.text = "Match Color";
        }
    }
    
    
    public void UpdateScore(int scoretoAdd)
    {
        score += scoretoAdd;
        scoreText.text = "Score: " + score;
        ComputeAccuracy();
    }

    public void ComputeAccuracy()
    {
        accuracy = (float) score / stimuli.events;
        Debug.Log("Accuracy: " + accuracy);
    }

    public void UpdateReactList(float delta)
    {
        reactionTimeList = new List<float> (reactionTimeList.Append(delta));
    }
   
}