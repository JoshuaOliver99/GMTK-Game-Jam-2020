using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdSpawner : MonoBehaviour
{
    public GameObject AdPrefab; // referance to the Ad prefab

    float clock; // Holds play time
    float spawnerClock; // Spawn clock

    int difficulty;
    int spawnDelay; // time required till a spawn

    private void Awake()
    {
        clock = 0.0f;
        spawnerClock = 0.0f;

        difficulty = 0;
        spawnDelay = 5;
    }

    void Update()
    {
        clock += Time.deltaTime;
        spawnerClock += Time.deltaTime;

        updateDifficulty();

        if (spawnerClock > spawnDelay) // if (spawn delay eclipsed)
        {
            //Debug.Log(spawnDelay + " SECONDS HAS PASSED");
            Vector3 position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 4.0f), Random.Range(-5.0f, 5.0f)); // Random position within the screen bounds
            GameObject newAd = Instantiate(AdPrefab, position, Quaternion.identity); // spawn an ad
            newAd.transform.localScale = new Vector3(Random.Range(1.0f, 2.0f), Random.Range(1.0f, 2.0f), 0); // Scale spawned ad
            spawnerClock = 0; // Reset spawn clock
        }

    }

    void updateDifficulty()
    {
        if (clock < 60)
        {
            spawnDelay = 5;
        }
        else if (clock > 120)
        {
            spawnDelay = 4;
        }
        else if (clock < 180)
        {
            spawnDelay = 3;
        }
        else if (clock < 240)
        {
            spawnDelay = 2;
        }
        else if (clock >= 240)
        {
            spawnDelay = 1;
        }
    }
}


/*
switch(difficulty)
{
    case 1:
        Debug.Log("DIFFICULTY 1");
        break;
    case 2:
        Debug.Log("DIFFICULTY 2");
        break;
    case 3:
        Debug.Log("DIFFICULTY 3");
        break;
    case 4:
        Debug.Log("DIFFICULTY 4");
        break;
    case 5:
        Debug.Log("DIFFICULTY 5");
        break;
    default:
        Debug.Log("DIFFICULTY OOB");
        break;
} */
