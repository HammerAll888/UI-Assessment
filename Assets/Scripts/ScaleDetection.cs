using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScaleDetection : MonoBehaviour
{
    //Defining game objects
    [SerializeField] GameObject FirstPromt;
    [SerializeField] GameObject SecondPromt;
    public TextMeshProUGUI Objective;

    //Detects when the player has entered a collider
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Scale")
        {
            FirstPromt.SetActive(false); //Will turn off the "FirstPromt" game object
            SecondPromt.SetActive(true); //Will turn on the "SecondPromt" game object
            Objective.color = Color.green; //Will change the colour of the objective text
        }
    }

    //Detects when the player has left a collider
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Scale")
        {
            FirstPromt.SetActive(true); //Will turn on the "FirstPromt" game object
            SecondPromt.SetActive(false); //Will turn off the "SecondPromt" game object
        }
    }
}
