using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdSpawner : MonoBehaviour
{
    private float timer = 0.0f; // Spawn timer
    public GameObject AdPrefab; // referance to the Ad prefab

    void Start()
    {
        timer = 0.0f;
    }



    void Update()
    {
        timer += Time.deltaTime; // dis

        if (timer > 5)
        {
            Debug.Log("5 SECONDS HAS PASSED");

            // ----- SHOULD DO ----
            // SPAWN AN AD PREFAB
            // AD HAS RANDOM AD IMAGE


            Instantiate(AdPrefab, Vector3.zero, Quaternion.identity); // spawn an ad

            timer = 0; // Reset timer
        }


    }
}
