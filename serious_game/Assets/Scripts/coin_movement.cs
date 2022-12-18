using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using System;

public class coin_movement : MonoBehaviour
{
    public float speed = 3000;
    public int coin_type;
    private int scoreToAdd;
    private int stimuli_type;
    public int score;

    private ReactionTime reactionTime;
    private GameManager gameManager;
    private stimuli_spawner stimuli;
    
    public AudioSource score_sound;
    
    Color stimuli_color;
    Color coin_color;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        stimuli = GameObject.Find("STIMULI").GetComponent<stimuli_spawner>();
        reactionTime = GameObject.Find("ReactionTime").GetComponent<ReactionTime>();
        score_sound = scoreText.GetComponent<AudioSource>();
       
    }
    void Update()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));

        if (transform.position.x < -2600)
           gameObject.SetActive(false);
 
    }


    void OnTriggerEnter(Collider others)
    {
        scoreToAdd = 0;
        

        stimuli_type = stimuli.current_type;
        stimuli_color = stimuli.current_color;
        coin_color = gameObject.GetComponentInChildren<MeshRenderer>().material.GetColor("_Color");

        if (gameManager.state == 0 & coin_type == stimuli_type)
        {
            scoreToAdd = 1;
            score_sound.Play();
            gameManager.correct += 1;
        }

        if (gameManager.state == 1 & stimuli_color == coin_color)
        {
            scoreToAdd = 3;
            score_sound.Play();
            gameManager.correct += 1;
        }

        if (gameManager.state == 2)
        {
            if (stimuli.rand_state == 0 & coin_type == stimuli_type)
            {
                scoreToAdd = 5;
                score_sound.Play();
                gameManager.correct += 1;
            }
            if (stimuli.rand_state == 1 & stimuli_color == coin_color)
            {
                scoreToAdd = 5;
                score_sound.Play();
                gameManager.correct += 1;
            }
        }

        gameObject.SetActive(false);
        gameObject.transform.position = new Vector3(-3000, 150, 2000);
        score = gameManager.UpdateScore(scoreToAdd);
        scoreText.text = "Score: " + score;
       
        

        double delta_react = stimuli.startTimeBtwnSpawn - reactionTime.reactionTime ;
        delta_react = Math.Round(delta_react, 2);

        Debug.Log("Reaction time: " + delta_react);

        if (delta_react > 0.3)
            gameManager.UpdateReactList(delta_react);
        
        reactionTime.reactionTime = 0;
    }
}
