using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to destory the enemy when the projectile hits it
public class DetctCollisions : MonoBehaviour
{
    //Declare variables
    public ParticleSystem explosionParticle;

    //When the projectile hits the enemy destroy both
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
    }
}
