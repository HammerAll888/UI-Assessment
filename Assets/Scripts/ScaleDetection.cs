using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider Scale)
    {
        if(Scale.tag == "Player")
        {
            Debug.Log("You fat fuck");
        }
    }
}
