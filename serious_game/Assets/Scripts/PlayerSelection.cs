using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject Player0;
    public GameObject Player1;
    void Awake()
    {
        Player0.SetActive(false);
        Player1.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gameManager.player == 0)
        {
            Player0.transform.position = new Vector3(-1600, 0, 2000);
            Player0.SetActive(true);
        }
        else 
        {
            Player1.transform.position = new Vector3(-1600, 0, 2000);
            Player1.SetActive(true);
        }
    }
}
