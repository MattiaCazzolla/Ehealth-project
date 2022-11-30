using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{ 
    public static GameManager Instance { get; private set; }
    public string username;
    private void Awake()
    {
        if(Instance == null){
           Instance = this;
        }
        else{
           Destroy(gameObject);
        }
    DontDestroyOnLoad(target: this);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
