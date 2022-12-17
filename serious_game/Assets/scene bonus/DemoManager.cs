using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DemoManager : MonoBehaviour
{
    public float delayBeforeLoading = 30f;
    public int sceneBuildIndexToLoad;
    private float timeElapsed;

    
    public int score;

    public TextMeshProUGUI scoreText;
    private DemoManager demoManager;
    

    private void Start()
    {
        demoManager = GameObject.Find("DemoManager").GetComponent<DemoManager>();   
        score = 0;
        UpdateScore(score);
       
    }


    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneBuildIndexToLoad);
            
        }

       
    }


    public void UpdateScore(int scoretoAdd)
    {
        score += scoretoAdd;
        scoreText.text = "Score: " + score;
        Debug.Log("score added");
    }

}

