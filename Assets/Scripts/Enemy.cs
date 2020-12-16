using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows enemy to follow player
public class Enemy : MonoBehaviour
{
    //Declare private variables
    private Rigidbody enemyRb;  //rigidbody of enemy for 
    private GameObject player;  //gameObject of the player for the enemy to chase

    //Decalre public variables
    public float speed = 50.0f; //Enemy speed

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Allows the enemy to follow the player
        enemyRb.AddForce((player.transform.position - transform.position) * speed);
    }
}
