using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public GameObject enemyObj;
    public GameObject playerObj;

    void OnTriggerEnter(Collider other)
    {
        Destroy(enemyObj);
        Destroy(playerObj);


    }

    //Load scene
    public void restartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
