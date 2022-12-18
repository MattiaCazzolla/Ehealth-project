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
    public double accuracy;
    public int correct=0;
    public int player = 0;
    public int colorblind;
    public int totalScore;

    public List<double> reactionTimeList = new List<double>();

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

        accuracy = (double) correct / stimuli.events;
        accuracy = Math.Round(accuracy, 2);

        Debug.Log("Accuracy: " + accuracy);
    }

    public void UpdateReactList(double delta)
    {
        reactionTimeList = new List<double> (reactionTimeList.Append(delta));
    }

    public void SaveScore()
    {
        totalScore += score;
    }
 }