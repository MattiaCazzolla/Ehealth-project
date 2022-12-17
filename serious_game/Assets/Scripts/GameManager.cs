using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using TMPro;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int state = 0;
    public int rand_state;
    public int score=0;
    public float accuracy;
    public int player = 0;

    public List<float> reactionTimeList = new List<float>();

    private stimuli_spawner stimuli;
    public GameManager gameManager;

    void Start()
    {
        DontDestroyOnLoad(gameManager);
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