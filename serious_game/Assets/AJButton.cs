using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AJButton : MonoBehaviour
{
    public GameManager gameManager;
    public void AJ()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.player=1;
    }
}
