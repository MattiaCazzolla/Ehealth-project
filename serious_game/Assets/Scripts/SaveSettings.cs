using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class SaveSettings : MonoBehaviour
{
    public GameManager gameManager;
    public void SaveToJson()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        settings_data _data = new settings_data();
        _data.Character = gameManager.player;
        _data.Colorblind = gameManager.colorblind;

        string json = JsonUtility.ToJson(_data, true);
        File.WriteAllText("settings.json", json);
    }
}
