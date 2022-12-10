using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 30f;
    [SerializeField]
    private int sceneBuildIndexToLoad;
    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneBuildIndexToLoad);
        }
    }
    public int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
        UpdateScore(score);
    }

    // Update is called once per frame
    public void UpdateScore(int scoretoAdd)
    {
        score += scoretoAdd;
        scoreText.text = "Score: " + score;
        Debug.Log("score added");
    }
   
}