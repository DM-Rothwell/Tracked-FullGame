using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Declare private variables
    private int score;  //int to keep score
    public TextMeshProUGUI scoreText;   //textmesh to display the score to the user
    
    //Decalre public variables
    public bool gameActive;    //boolean to make the game active = true, or inactive = false

    // Start is called before the first frame update
    /*void Start()
    {
        UpdateScore(0);

        IEnumerator SpawnManager()
        {
            while (true)
            {
                UpdateScore(1);
            }//End of while
        }//end of IEnumerator
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }


    /*public void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = "Score: " + score;
        
    }*/

    //Used to start game when "Play Game" is clicked
    public object StartGame()
    {
        //"Turn on" the game so it is playable
        gameActive = true;
        score = 0;

        //StartCoroutine(SpawnManager());
        //UpdateScore(0);

        return StartGame();
    }

    //Method to restart the game when it is over
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene("Menu");
    }
}

