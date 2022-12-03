using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class coin_movement : MonoBehaviour
{
    public float speed = 3000;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));

        if (transform.position.x < -2600)
        {
           gameObject.SetActive(false);
        }
 
    }
    void OnTriggerEnter(Collider others)
    {
        int scoreToAdd=1;
        Debug.Log("hit a coin");
        gameObject.SetActive(false);
        gameObject.transform.position = new Vector3(-3000, 150, 2000);
        gameManager.UpdateScore(scoreToAdd);
    }
}
