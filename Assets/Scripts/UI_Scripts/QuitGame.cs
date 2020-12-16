using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public AudioSource click;
    public AudioClip clickAudio;

    //When the 'Quit' button is clicked it will close the application
    public void quitGame()
    {
        Application.Quit(); //Closes the application
        Debug.Log("Game Quit");
    }

    public void buttonClick()
    {
        click.PlayOneShot(clickAudio);
    }
}
