using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class ReactionTime : MonoBehaviour
{
    private float timeElapsed;
    public float reactionTime = 0;
    public List<float> reactionTimeList = new List<float>();
    public GameManager gameManager;
    public int sceneBuildIndexToLoad = 2;

    public float NeutralStimuli = 15f;
    public float ConStimuli = 20f;
    public float InconStimuli = 30f;

    public float delayBeforeLoading ;


    void Start()
    {
        delayBeforeLoading = NeutralStimuli + ConStimuli + InconStimuli;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        reactionTime += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            if (reactionTimeList.Count < 1)
            {
                //Debug.Log("Avg reaction time: " + 5);
            }
            else
            {
                Debug.Log("Avg reaction time: " + reactionTimeList.Average());
            }
        }

        if(timeElapsed<NeutralStimuli)
        {
            gameManager.state = 0;
        }
        else if (timeElapsed>=NeutralStimuli && timeElapsed<NeutralStimuli+ConStimuli)
        {
            gameManager.state = 1;
        }
        else if (timeElapsed>= NeutralStimuli+ConStimuli && timeElapsed<NeutralStimuli+ConStimuli+InconStimuli)
        {
            gameManager.state = 1;
        }
        else
        {
            SceneManager.LoadScene("Transition");
        }
    }
}
