using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to allow the camera to follow the player

public class CameraFollow : MonoBehaviour
{
    //Public variables
    public GameObject player;

    //Private Variables
    private Vector3 offset = new Vector3(0, 4, -4);  //position of camera from player


    // Update is called once per frame
    void Update()
    {
        //Offset the camera by adding to the players position
        transform.position = player.transform.position + offset;
    }
}
