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

    //Public variables
    public GameObject projectilePrefab; //Decalre a GamObject for the projectile to be fired
    private Rigidbody playerRb;

    //Variables to end game
    public Button restartButton;
    public TextMeshProUGUI gameOverText;
    public bool isgameActive = true;
    public AudioSource end;

    void Start()
    {
        end = GetComponent<AudioSource>();    
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

    //Private void to display gameover
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            isgameActive = false;
            end.Play();
        }
    }

}//End of class