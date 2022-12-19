using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusButton : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void LoadGameScene()
    {
        gameManager.accuracy = 0;
        SceneManager.LoadScene("BonusLevel");
    }
}
