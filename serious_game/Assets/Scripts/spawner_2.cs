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

    public int lenghtLists = 0;
    public List<GameObject> Objects0 = new List<GameObject>();
    public List<GameObject> Objects1 = new List<GameObject>();
    public List<GameObject> Objects2 = new List<GameObject>(); //object 2=emerald 

    public int i = 0;
    public int j = 0;
    public int k = 0;

    private void Awake()
    {
        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject new_Object0;
        GameObject new_Object1;
        GameObject new_Object2;


        if (timeFromSpawn <= 0)
        {
            int rand_position = Random.Range(0, possiblePositions.Count);
            int rand_object = Random.Range(0, possibleObjects.Count);

            if (rand_object == 0)
            {
                if (Objects0.Count <= lenghtLists)
                {
                    new_Object0 = Instantiate(possibleObjects.ElementAt(rand_object), new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500), Quaternion.Euler(0,90,0));
                    Objects0.Add(new_Object0);
                    new_Object0.SetActive(true);
                }
                else
                
                {
                    if (i >= 0 && i < lenghtLists)
                    {
                        new_Object0 = Objects0[i];
                        new_Object0.transform.position = new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500);
                        new_Object0.SetActive(true);
                        i++;
                    }
                    else if (i == lenghtLists)
                    {
                        new_Object0 = Objects0[lenghtLists];
                        new_Object0.transform.position = new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500);
                        new_Object0.SetActive(true);
                        i = 0;
                    }
                }
            }
            if (rand_object == 1)
            {
                if (Objects1.Count <= lenghtLists)
                {
                    new_Object1 = Instantiate(possibleObjects.ElementAt(rand_object), new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500), Quaternion.Euler(0, 90, 0));
                    Objects1.Add(new_Object1);
                    new_Object1.SetActive(true);
                }
                else
                {
                    if (j >= 0 && j < lenghtLists)
                    {
                        new_Object1 = Objects1[j];
                        new_Object1.transform.position = new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500);
                        new_Object1.SetActive(true);
                        j++;
                    }
                    else if (j == lenghtLists)
                    {
                        new_Object1 = Objects1[lenghtLists];
                        new_Object1.transform.position = new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500);
                        new_Object1.SetActive(true);
                        j = 0;
                    }
                }
            }
            if (rand_object == 2)
            {
                if (Objects2.Count <= lenghtLists)
                {
                    new_Object2 = Instantiate(possibleObjects.ElementAt(rand_object), new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500), Quaternion.Euler(0, 90, 0));
                    Objects2.Add(new_Object2);
                    new_Object2.SetActive(true);
                }
                else
                {
                    if (k >= 0 && k < lenghtLists)
                    {
                        new_Object2 = Objects2[k];
                        new_Object2.transform.position = new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500);
                        new_Object2.SetActive(true);
                        k++;
                    }
                    else if (k == lenghtLists)
                    {
                        new_Object2 = Objects2[lenghtLists];
                        new_Object2.transform.position = new Vector3(possiblePositions.ElementAt(rand_position), 1500, 2500);
                        new_Object2.SetActive(true);
                        k = 0;
                    }
                }
            }
            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
    }
}
