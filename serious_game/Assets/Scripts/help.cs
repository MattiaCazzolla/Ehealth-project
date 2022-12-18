using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class help : MonoBehaviour
{
    public void LoadGameScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 7){
            SceneManager.LoadScene("DemoLevel1");
        }
        else {
            SceneManager.LoadScene("Demo"); 
        }
    }
}
