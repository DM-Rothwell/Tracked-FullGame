using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to destory the enemy when the projectile hits it
public class DetctCollisions : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }



    public void OnCollisionEnter(Collision collision)
    {

    }


}
