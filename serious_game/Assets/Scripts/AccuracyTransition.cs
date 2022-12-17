using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccuracyTransition : MonoBehaviour
{
    public TextMeshProUGUI accuracyText;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        accuracyText.text = "Accuracy : " + gameManager.accuracy;

    }

}