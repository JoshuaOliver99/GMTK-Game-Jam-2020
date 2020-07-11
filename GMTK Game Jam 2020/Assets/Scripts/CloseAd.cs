using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAd : MonoBehaviour
{

    void OnMouseDown()
    {
        Debug.Log("CLICKED: " + gameObject.name);

        Destroy(transform.parent.gameObject); // destroys Ad
    }
}
