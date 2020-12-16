using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    //Used to turn off the background music of the main menu
    //Private variable
    private bool muted;

    // Start is called before the first frame update
    void Start()
    {
        //muted = false;
    }

    //When the toggle button is pressed turn of the music
    public void muteToggled()
    {
        muted = true;
        AudioListener.volume = 0;
    }
}
