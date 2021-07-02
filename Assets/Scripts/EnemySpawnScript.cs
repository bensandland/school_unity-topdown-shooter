using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemyObject;
    public float spawnSpeed = 5f;
    public float[] spawnLocationSides = { 5f, -9.6f, -5f, 8.9f };

    float randomCoord;
    Vector2 spawnLocation;
    float nextSpawn = 0.0f;
    

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnSpeed;
            
            int spawnSideIndex = Random.Range(0, 4);

            switch (spawnSideIndex)
            {
                case 0:
                    // x
                    randomCoord = Random.Range(-9.2f, 8.4f);
                    break;
                case 1:
                    // y
                    randomCoord = Random.Range(4.2f, -4.8f);
                    break;
                case 2:
                    // x
                    randomCoord = Random.Range(-8.7f, 7.9f);
                    break;
                case 3:
                    // y
                    randomCoord = Random.Range(4.2f, -4.8f);
                    break;
                default:
                    break;
            }

            if (spawnSideIndex % 2 == 0)
                spawnLocation = new Vector2(randomCoord, spawnLocationSides[spawnSideIndex]);
            else
                spawnLocation = new Vector2(spawnLocationSides[spawnSideIndex], randomCoord);
            

            Instantiate(enemyObject, spawnLocation, Quaternion.identity);
        }
    }

}
