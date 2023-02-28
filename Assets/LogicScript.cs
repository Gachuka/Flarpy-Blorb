using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool gameIsAlive = true;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (gameIsAlive)
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        Debug.Log("Restarted Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void returnToTitle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameIsAlive = false;
    }

    public void exitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitGame();
        }
    }
}
