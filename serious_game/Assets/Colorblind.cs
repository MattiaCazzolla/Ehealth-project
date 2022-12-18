using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorblind : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void ColorblindFunction()
    {
        if (gameManager.colorblind == 0)
        {
            gameManager.colorblind = 1;
        }
        else if (gameManager.colorblind == 1)
        {
            gameManager.colorblind = 0;
        }
    }
}
