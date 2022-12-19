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

public class LoadScore : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        string json = File.ReadAllText("score.json");
        score_stats __data = JsonUtility.FromJson<score_stats>(json);
        gameManager.totalScore = __data.TotScore;
    }
}
