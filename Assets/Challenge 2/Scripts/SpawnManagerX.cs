﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    public int  RandomBallPrefabs;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(3.0f,6.0f));
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

            RandomBallPrefabs = Random.Range(1, 3);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location

        Instantiate(ballPrefabs[RandomBallPrefabs], spawnPos, ballPrefabs[RandomBallPrefabs].transform.rotation);

        //Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);
        Debug.Log(Random.Range(3f,6f));
    }



}

