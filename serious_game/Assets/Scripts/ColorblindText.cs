using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorblindText : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI colorblindText;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void FixedUpdate()
    {
        if (gameManager.colorblind == 0)
        {
            colorblindText.text = "Colorblind mode: OFF";
        }
        if (gameManager.colorblind == 1)
        {
            colorblindText.text = "Colorblind mode: ON";
        }
    }
}
