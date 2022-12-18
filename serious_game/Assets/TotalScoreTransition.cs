using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScoreTransition : MonoBehaviour
{
    public TextMeshProUGUI totalScoreText;
    public GameManager gameManager;
    public int newTotal;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        newTotal= gameManager.score + gameManager.totalScore;
        totalScoreText.text = "Your total score: " + newTotal;
    }
}
