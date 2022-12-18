using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManagerBonus : MonoBehaviour
{
    private float timeElapsed;
    public GameManager gameManager;

    public float delayBeforeLoading=20;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= delayBeforeLoading)
        {
            gameManager.SaveScore();
            gameManager.score = 0;
            SceneManager.LoadScene("Menu");
        }
    }
}
