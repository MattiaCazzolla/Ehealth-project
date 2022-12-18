using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChosenCharacter : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI characterText;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gameManager.player == 0)
        {
            characterText.text = "Chosen character: Amy";
        }
        else if (gameManager.player == 1)
        {
            characterText.text = "Chosen character: AJ";
        }
    }
}
