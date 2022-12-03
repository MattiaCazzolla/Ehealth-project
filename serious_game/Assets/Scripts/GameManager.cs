using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
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
        scoreText.text = "Score:" + score;
        Debug.Log("score added");
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
//per caricare solo la demo o le settings quando clicco il button usare 
// SceneManager.LoadScene("Settings");
// Scenemanager.LoadScene("Demo");
}
