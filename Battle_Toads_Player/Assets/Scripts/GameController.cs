using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //All score texts
    public static Text scoreText;
    public static Text scoreText2;
    public Text pauseGameText;
    public Text endLevelText;
    public Text restartGameText;
    int score = 0;

    void Start()
    {
        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
        scoreText2 = GameObject.Find("Score Text (1)").GetComponent<Text>();
        scoreText.text = "Score: 0";
        scoreText.text = "Score: 0";
    }

    //Add score to all scoreTexts
    public void AddScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
        scoreText2.text = "Score: " + score;
        pauseGameText.text = "Score: " + score;
        endLevelText.text = "Score: " + score;
        restartGameText.text = "Score: " + score;

        Debug.Log(scoreText.text);
    }


}
