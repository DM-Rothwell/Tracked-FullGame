using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScripts : MonoBehaviour
{

    //Script used to be able to control what buttons do 

    //Public variables
    public bool muted;

    //When the toggle button is pressed turn of the music
    public void muteToggled()
    {
        muted = true; //Set muted to true when the muteToggled is checked
        AudioListener.volume = 0;   //When the mute togle is true set the value to 0
    }

    //Open Game
    public void openGame()
    {
        SceneManager.LoadScene("SampleScene"); //open "SampleScene"
        Debug.Log("Opened Game");
    }

    //Open Link
    public void openLink()
    {
        Application.OpenURL("https://github.com/DM-Rothwell/Tracked-FullGame"); //Link for my github
    }


    //Close Game
    public void quitGame()
    {
        Application.Quit(); //Closes the application
        Debug.Log("Game Quit");
    }

    //Restart Game
    public void restartTheGame()
    {
        SceneManager.LoadScene("Menu"); //Open the menu scene when the restart button is clicked
    }


}
