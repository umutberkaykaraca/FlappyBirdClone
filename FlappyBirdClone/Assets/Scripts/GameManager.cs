using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void Start()
    {
        Time.timeScale = 1;
    }

    // Activates the canvas when the game is over.
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    // Loads scene 1 to start game.
    public void Replay()
    {
        SceneManager.LoadScene(1); 
    }
    
    // Loads scene 0 to main menu.
    public void Back()
    {
        SceneManager.LoadScene(0); 
    }
}
