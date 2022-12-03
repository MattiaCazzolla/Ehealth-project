using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings_scene : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Settings");
    }
}
