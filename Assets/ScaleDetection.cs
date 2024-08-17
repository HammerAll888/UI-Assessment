using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScaleDetection : MonoBehaviour
{
    [SerializeField] GameObject FirstPromt;
    [SerializeField] GameObject SecondPromt;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Scale")
        {
            FirstPromt.SetActive(false);
            SecondPromt.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Scale")
        {
            FirstPromt.SetActive(true);
            SecondPromt.SetActive(false);
        }
    }
}
