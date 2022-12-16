using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using TMPro;
using System.Linq;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float delayBeforeLoading = 30f;
    public int sceneBuildIndexToLoad;
    private float timeElapsed;

    public int state = 0;
    public int rand_state;
    public int score;
    public float accuracy;
    public int player = 0;

    public float reactionTime = 0;
    public List<float> reactionTimeList = new List<float>();

    private stimuli_spawner stimuli;

    public GameManager gameManager;

    void Start()
    {
        DontDestroyOnLoad(gameManager);
        score = 0;
    }


    private void Update()
    {
        timeElapsed += Time.deltaTime;
        reactionTime += Time.deltaTime;

        if(timeElapsed > delayBeforeLoading)
        {
            if (reactionTimeList.Count < 1)
            {
                //Debug.Log("Avg reaction time: " + 5);
            }
            else
            {
                Debug.Log("Avg reaction time: " + reactionTimeList.Average());
            }
            SceneManager.LoadScene(sceneBuildIndexToLoad);
        }
    }
    
    
    public int UpdateScore(int scoretoAdd)
    {
        score += scoretoAdd;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            ComputeAccuracy();
        }
        return score;
    }

    public void ComputeAccuracy()
    {
        stimuli = GameObject.Find("STIMULI").GetComponent<stimuli_spawner>();
        accuracy = (float) score / stimuli.events;
        Debug.Log("Accuracy: " + accuracy);
    }

    public void UpdateReactList(float delta)
    {
        reactionTimeList = new List<float> (reactionTimeList.Append(delta));
    }
   
}