﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] enemies;
    public int[] enemyChance;
    private int chanceNumber;

    //private Dictionary<GameObject, float> dictionary = new Dictionary<GameObject, float>();


    // Start is called before the first frame update
    void Start()
    {
        //loadData();
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Transform spawnLocation = spawnPoints[i].transform;

            chanceNumber = Random.Range(0, 100);
            //Debug.Log(chanceNumber);

            for (int index = 0; index < enemies.Length; index++)
            {
                if (chanceNumber > 0)
                {
                    chanceNumber = chanceNumber - enemyChance[index];
                    if (chanceNumber <= 0)
                    {
                        Instantiate(enemies[index], spawnLocation.position, spawnLocation.rotation);
                    }
                }
            }
        }
    }

    //private void loadData()
    //{
    //    GameObject aKey;
    //    float aValue;

    //    for (int index = 0; index < enemies.Length; index++)
    //    {
    //        aKey = enemies[index];
    //        aValue = enemyChance[index];

    //        dictionary[aKey] = aValue;
    //    }
    //}

    void Update()
    {
        
    }
}
