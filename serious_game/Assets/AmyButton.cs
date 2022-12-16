using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmyButton : MonoBehaviour
{
    public GameManager gameManager;
    public void AMY()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.player = 0;
    }
}
