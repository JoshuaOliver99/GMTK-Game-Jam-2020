using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdSpawner : MonoBehaviour
{
    public GameObject AdPrefab; // referance to the Ad prefab

    Sprite[,] adSprites = new Sprite[5, 4]; // holds all ad  sprites

    float clock; // Holds play time
    float spawnerClock; // Spawn clock

    int difficulty;
    int spawnDelay; // time required till a spawn

    private void Start()
    {
        clock = 0.0f;
        spawnerClock = 0.0f;

        difficulty = 0;
        spawnDelay = 5;

        loadAdImgs();
    }

    void Update()
    {
        clock += Time.deltaTime;
        spawnerClock += Time.deltaTime;

        updateDifficulty();

        if (spawnerClock > spawnDelay) // if (spawn delay eclipsed)
        {
            Debug.Log(spawnDelay + " SECONDS HAS PASSED");

            Vector3 position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 4.0f), Random.Range(-5.0f, 5.0f)); // Random position within the screen bounds
            GameObject newAd = Instantiate(AdPrefab, position, Quaternion.identity); // spawn an ad

            float newScale = Random.Range(2, 5);
            newAd.transform.localScale = new Vector3(newScale, newScale, 0); // Scale of spawned ad

            newAd.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = adSprites[Random.Range(0, difficulty), Random.Range(0, 3)]; // Sets the sprite of the ad dependant on difficulty

            spawnerClock = 0; // Reset spawn clock
        }

    }

    // The one time load which saves referance to all ad sprites
    void loadAdImgs()
    {
        for (int i = 0; i < 5; i++) // for (each ad level)
        {
            for (int j = 0; j < 4; j++) // for (RANDOM NUM ATM, number of each type of ad image)
            {
                var sprite = Resources.Load<Sprite>("Ads/Ad" + i + "_" + j);
                adSprites[i, j] = sprite; 
            }
        }
        
    }

    void updateDifficulty()
    {
        if (difficulty != 0 && clock >= 0 && clock < 15)
        {
            difficulty = 0;
            spawnDelay = 5;
        }
        else if (difficulty != 1 && clock >= 15 && clock < 30)
        {
            difficulty = 1;
            spawnDelay = 4;
        }
        else if (difficulty != 2 && clock >= 30 && clock < 45)
        {
            difficulty = 2;
            spawnDelay = 3;
        }
        else if (difficulty != 3 && clock >= 45 && clock < 60)
        {
            difficulty = 3;
            spawnDelay = 2;
        }
        else if (difficulty != 4 && clock >= 75)
        {
            difficulty = 4;
            spawnDelay = 1;
        }
    }
}
