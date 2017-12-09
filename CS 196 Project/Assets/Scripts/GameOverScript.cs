using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    //A UI Panel GameObject
    public GameObject gameOverPanel;
    //A UI Text element
    public Text gameOverText;
    
    //Sets the Panel inactive at the start of the game. Should be called at the start of every game
    public void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void Update()
    {
        GameOver();
    }
    //Sets the Panel active. Should be called upon player death
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = "Game Over!";
    }
}
