using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.UI;


public class ColourGameController : MonoBehaviour
{
    public GameObject redCircle;
    public GameObject greenCircle;
    public GameObject blueCircle;
    public GameObject pinkCircle;
    public GameObject orangeCircle;
    public GameObject yellowCircle;

    public GameObject mainText;
    public GameObject timerText;
    
    public float timeRemaining;
    public int Matches;

    public string collidedColour;
    public string requiredColour;

    public string[] colour = new string[6] {"Red", "Green", "Blue", "Pink", "Orange", "Yellow"};

    void Start()
    {
        timeRemaining = 10.0f;
        Matches = 0;

        collidedColour = "none";
        requiredColour = colour[Random.Range(0, 5)]; // change required colour
        mainText.GetComponent<TextMesh>().text = "Collide with: " + requiredColour; // Update required colour text
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

        timerText.GetComponent<TextMesh>().text = timeRemaining.ToString(); // Update timer

        if (collidedColour == "none")
        {
            //Debug.Log("no colour collided");
        }
        else if (collidedColour == requiredColour) // if (correct match)
        {
            Matches++;
            requiredColour = colour[Random.Range(0, 5)]; // change required colour
            mainText.GetComponent<TextMesh>().text = "Collide with: " + requiredColour; // Update required colour text
            collidedColour = "none";
            timeRemaining += 5;
        }
        else
            mainText.GetComponent<TextMesh>().text = ("Incorrect match! Correct matchs: " + Matches);


        if (timeRemaining < 0 ) // Loose
        {
            mainText.GetComponent<TextMesh>().text = ("Time Ran out! Correct matchs: " + Matches);
        }
    }
}
