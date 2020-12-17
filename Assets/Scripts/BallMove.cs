using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Used for the projectile to move

public class BallMove : MonoBehaviour
{
    //Declare Variables
    public float speed = 35.0f; //Variable that controls the speed of the enemy ball
    private float topBound = 75.0f;
    public GameObject projectile;
    public GameObject wall;

    // Update is called once per frame
    void Update()
    {
        //Generate ball at spawn pos
        Vector3 spawnPos = new Vector3(Random.Range(0, 0), 1, 1);

        //Move ball
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    //If the ball goes past a range of 25 destroy it


}
