using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class help : MonoBehaviour
{
    public void LoadGameScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4){
            SceneManager.LoadScene("Demo_Level1");
        }
        else {
            SceneManager.LoadScene("Demo"); 
        }
    }
}
