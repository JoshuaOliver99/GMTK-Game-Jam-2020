using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdSpawner : MonoBehaviour
{
    private float timer = 0.0f;

    void Start()
    {
        timer = 0.0f;
        var loadedObject = Resources.Load("Ad");
    }



    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);

        if (timer > 5)
        {
            Debug.Log("5 SECONDS HAS PASSED");

            // SPAWN AN AD PREFAB
            // AD HAS RANDOM AD IMAGE


            Instantiate(loadedObject, Vector3.zero, Quaternion.identity); // spawn an ad


            timer = 0; // Reset timer
        }


    }
}
