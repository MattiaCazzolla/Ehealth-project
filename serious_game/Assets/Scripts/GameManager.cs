using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   public void LoadGameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
//per caricare solo la demo o le settings quando clicco il button usare 
// SceneManager.LoadScene("Settings");
// Scenemanager.LoadScene("Demo");
}
