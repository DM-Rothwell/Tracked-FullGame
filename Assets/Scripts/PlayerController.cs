using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Used to have control over the players movement and to throw the ball when 'K' is pressed

public class PlayerController : MonoBehaviour
{
    //Private Variables 
    private float speed = 15.0f;    //Speed of player
    private float turnSpeed = 100.0f;   //How fast the player turns
    private float horizontalInput;  //Control for AD or left and right arrow keys
    private float fowardInput;  //Control WS or up and down on the arrow keys
    private float powerSpeed = 30.0f;

    //Public variables
    public GameObject projectilePrefab; //Decalre a GamObject for the projectile to be fired
    public bool hasPowerup;

    //RestartGame
    public Button restartButton;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive = true;
    public GameObject enemy;

    //Code for if statement             GameObject.FindGameObjectsWithTag("Enemy")

    private void OnCollisionEnter(Collision collision)
    {

    }


    void OnTriggerEnter(Collider other)
    {
            LayerMask enemy = LayerMask.GetMask("Enemy");
       
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            isGameActive = true;
        
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


    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
        }
    }*/

}//End of class