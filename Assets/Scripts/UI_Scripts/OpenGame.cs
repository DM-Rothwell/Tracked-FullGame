using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Used to be able to load the scene in

public class OpenGame : MonoBehaviour
{
    //This is used to load the Scene when the Play button is clicked on the Menu
    public void onClick()
    {
        SceneManager.LoadScene("SampleScene"); //open "SampleScene"
        Debug.Log("Opened Game");    
    }
}
