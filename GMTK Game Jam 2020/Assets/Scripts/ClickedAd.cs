using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedAd : MonoBehaviour
{

    void OnMouseDown()
    {
        Debug.Log("CLICKED: " + gameObject.name);

        Destroy(transform.parent.gameObject);
    }

}
