using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawner_2 : MonoBehaviour
{
    public List<GameObject> possibleObjects;
    public List<float> possiblePositions;

    public float startTimeBtwnSpawn;
    public float timeFromSpawn;

   

    // Update is called once per frame
    void Update()
    {
        if (timeFromSpawn <= 0)
        {
            int rand_position = Random.Range(0, possiblePositions.Count);
            int rand_object = Random.Range(0, possibleObjects.Count);

            Instantiate(possibleObjects.ElementAt(rand_object), new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500), Quaternion.Euler(0,90,0));
            timeFromSpawn = startTimeBtwnSpawn;
        }
    
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }

    }
}