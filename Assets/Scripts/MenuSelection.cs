using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    //Loads the Playground scene when the start button is pressed
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    //Quits the game when the Quit button is pressed
    public void QuitGame()
    {
        Application.Quit();
    }
}
