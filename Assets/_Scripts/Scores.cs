using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private int score;
    private float highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetFloat("High Score");
        score = 0;
        UpdateScoreUI();
    }

    void Update()
    {
        score++;
        UpdateScoreUI();
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("High Score", highScore);
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
        highScoreText.text = "HighScore: " + highScore;
    }
}
