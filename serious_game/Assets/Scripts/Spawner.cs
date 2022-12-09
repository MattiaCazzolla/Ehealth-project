using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public List<GameObject> possibleObjects;
    public List<float> possiblePositions;
    public List<Color> possibleColors;

    public float startTimeBtwnSpawn;
    public float timeFromSpawn;

    public int lenghtLists=0;
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
            if (Objects0.Count <= lenghtLists)
            {
                new_Object0 = Instantiate(possibleObjects[0], new Vector3(6500, 0, possiblePositions[0]), Quaternion.identity);
                //new_Object0.AddComponent<MeshRenderer>();
                Objects0.Append(new_Object0);
                new_Object0.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[0]);
                new_Object0.SetActive(true);
            }
            else 
            {
                if (i >= 0 && i < lenghtLists)
                {
                    new_Object0 = Objects0[i];
                    new_Object0.transform.position = new Vector3(6500, 0, possiblePositions[0]);
                    new_Object0.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[0]);
                    new_Object0.SetActive(true);
                    i++;
                }
                else if (i == lenghtLists)
                {
                    new_Object0 = Objects0[lenghtLists];
                    new_Object0.transform.position = new Vector3(6500, 0, possiblePositions[0]);
                    new_Object0.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[0]);
                    new_Object0.SetActive(true);
                    i = 0;
                }
            }
            if (Objects1.Count <= lenghtLists)
            {
                new_Object1 = Instantiate(possibleObjects[1], new Vector3(6500, 150, possiblePositions[1]), Quaternion.identity);
                //new_Object1.AddComponent<MeshRenderer>();
                Objects1.Add(new_Object1);
                new_Object1.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[1]);
                new_Object1.SetActive(true);
            }
            else
            {
                if (j >= 0 && j < lenghtLists)
                {
                    new_Object1 = Objects1[j];
                    new_Object1.transform.position = new Vector3(6500, 150, possiblePositions[1]);
                    new_Object1.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[1]);
                    new_Object1.SetActive(true);
                    j++;
                }
                else if (j == lenghtLists)
                {
                    new_Object1 = Objects1[lenghtLists];
                    new_Object1.transform.position = new Vector3(6500, 150, possiblePositions[1]);
                    new_Object1.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[1]);
                    new_Object1.SetActive(true);
                    j = 0;
                }
            }
            if (Objects2.Count <= lenghtLists)
            {
                new_Object2 = Instantiate(possibleObjects[2], new Vector3(6500, 200, possiblePositions[2]), Quaternion.identity);
                //new_Object2.AddComponent<MeshRenderer>();
                Objects2.Add(new_Object2);
                new_Object2.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[2]);
                new_Object2.SetActive(true);
            }
            else
            {
                if (k >= 0 && k < lenghtLists)
                {
                    new_Object2 = Objects2[k];
                    new_Object2.transform.position = new Vector3(6500, 200, possiblePositions[2]);
                    new_Object2.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[2]);
                    new_Object2.SetActive(true);
                    k++;
                }
                else if (k == lenghtLists)
                {
                    new_Object2 = Objects2[lenghtLists];
                    new_Object2.transform.position = new Vector3(6500, 200, possiblePositions[2]);
                    new_Object2.GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", possibleColors[2]);
                    new_Object2.SetActive(true);
                    k = 0;
                }
            }
       
            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
        possiblePositions = ShufflePositions(possiblePositions);
        possibleColors = ShuffleColors(possibleColors);
    }

    public List<float> ShufflePositions(List<float> alpha)
    {
        for (int i = 0; i < alpha.Count; i++)
        {
            float temp = alpha[i];
            int randomIndex = Random.Range(i, alpha.Count);
            alpha[i] = alpha[randomIndex];
            alpha[randomIndex] = temp;
        }
        return alpha;
    }
    public List<Color> ShuffleColors(List<Color> alpha)
    {
        for (int i = 0; i < alpha.Count; i++)
        {
            Color temp = alpha[i];
            int randomIndex = Random.Range(i, alpha.Count);
            alpha[i] = alpha[randomIndex];
            alpha[randomIndex] = temp;
        }
        return alpha;
    }
}