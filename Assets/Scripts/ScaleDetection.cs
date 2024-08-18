using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScaleDetection : MonoBehaviour
{
    [SerializeField] GameObject FirstPromt;
    [SerializeField] GameObject SecondPromt;
    public TextMeshProUGUI Objective;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Scale")
        {
            FirstPromt.SetActive(false);
            SecondPromt.SetActive(true);
            Objective.color = Color.green;
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
