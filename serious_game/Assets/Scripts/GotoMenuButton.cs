using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMenuButton : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void LoadGameScene()
    {
        gameManager.SaveScore();
        gameManager.score = 0;
        SceneManager.LoadScene("Menu");
    }
}
