using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

//Used to spawn the enemy at random with waves

public class SpawnManager : MonoBehaviour
{
    //Declare Variables
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public int enemyCount;
    public int waveNumber = 1;
    public TextMeshProUGUI scoreText;
    public int score;

    //Max and Min range for ball to spawn on the X-axis
    private float spawnXRangeMin = 30.0f;
    private float spawnXRangeMax = 65.0f;

    //Max and Min range for ball to spawn on the Z-axis
    private float spawnZRangeMin = 55.0f;
    private float spawnZRangeMax = 70.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn enemy wave
        spawnEnemyWave(waveNumber);

        //Instantiate method to generate randomPos
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);    
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            spawnEnemyWave(waveNumber);
            scoreText.text = "Score: "+ waveNumber.ToString();
            //Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
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

    void spawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            score++;

            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}