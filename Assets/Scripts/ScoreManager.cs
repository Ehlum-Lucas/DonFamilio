using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI HighScoreText;
    public TextMeshProUGUI HighScoreText1;

    public float Score;
    public float HighScore;
    public float Speed = 0;

    public float PtsPerSecond;

    public bool is_score;

    private RandomGen enemy;

    // Start is called before the first frame update
    void Start()
    {
        is_score = true;
        enemy = FindObjectOfType<RandomGen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Speed < 200) {
            Speed += PtsPerSecond * Time.deltaTime;
        }
        else {
            Speed = 0;
            enemy.speed *= 1.1f;
        }
        if (is_score) {
            Score += PtsPerSecond * Time.deltaTime;
        }
        if (HighScore < Score)
            HighScore = Score;
        scoreText.text = "Score : " + Mathf.Round(Score);
        scoreText1.text = "Score : " + Mathf.Round(Score);
        HighScoreText.text = "High Score : " + Mathf.Round(HighScore);
        HighScoreText1.text = "High Score : " + Mathf.Round(HighScore);

    }
}
