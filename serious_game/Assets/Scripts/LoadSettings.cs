using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class LoadSettings : MonoBehaviour
{
    public GameManager gameManager;
    public settings_data __data;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        string json = File.ReadAllText("settings.json");

        __data = JsonUtility.FromJson<settings_data>(json);

        gameManager.player = __data.Character;
        gameManager.colorblind = __data.Colorblind;
    }

}
