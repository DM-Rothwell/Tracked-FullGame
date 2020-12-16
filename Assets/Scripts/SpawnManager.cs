using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;

//Used to spawn the enemy at random

public class SpawnManager : MonoBehaviour
{
    //Declare Variables
    public GameObject enemyPrefab;

    //Max and Min range for ball to spawn on the X-axis
    private float spawnXRangeMin = 30.0f;
    private float spawnXRangeMax = 65.0f;

    //Max and Min range for ball to spawn on the Z-axis
    private float spawnZRangeMin = 15.0f;
    private float spawnZRangeMax = 70.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate method to generate randomPos
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Create a method for the ball to spawn at a random location
    private Vector3 GenerateSpawnPosition()
    {
        //Variables used to spawn the random locations
        float spawnPosX = Random.Range(spawnXRangeMin, spawnXRangeMax);
        float spawnPosZ = Random.Range(spawnZRangeMin, spawnZRangeMax);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}