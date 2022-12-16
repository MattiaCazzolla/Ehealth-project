using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTransition : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreText.text = "Your score : " + gameManager.score;
    }

}
