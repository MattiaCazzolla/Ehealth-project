using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin_movement_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1000;
    private GameManager gameManager;
    public TextMeshProUGUI scoreText;
    public int score;
    public AudioSource coin_sound;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        coin_sound = scoreText.GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector3.down * (speed * Time.deltaTime));

        if (transform.position.y < 0)
        {
           gameObject.SetActive(false);
        }

    }

    void OnTriggerEnter(Collider others)
    {
        int scoreToAdd=1;
        Debug.Log("hit a coin");
        gameObject.SetActive(false);
        gameObject.transform.position = new Vector3(14000, 100, 2500);
        score = gameManager.UpdateScore(scoreToAdd);
        scoreText.text = "Score: " + score;
        coin_sound.Play();
    }
}

