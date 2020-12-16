using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to have control over the players movement and to throw the ball when 'K' is pressed

public class PlayerController : MonoBehaviour
{
    //Private Variables 
    private float speed = 15.0f;    //Speed of player
    private float turnSpeed = 100.0f;   //How fast the player turns
    private float horizontalInput;  //Control for AD or left and right arrow keys
    private float fowardInput;  //Control WS or up and down on the arrow keys

    //Public variables
    public GameObject projectilePrefab; //Decalre a GamObject for the projectile to be fired

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Player input   
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        //Move person foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);

        //Turn Person
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        //'K' for projecting a ball
        if (Input.GetKeyDown(KeyCode.K)){
            //Shoot the projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }//End of if
    }
}//End of class