using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{

    public void exitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void playGame()
    {
        Debug.Log("Starting Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
