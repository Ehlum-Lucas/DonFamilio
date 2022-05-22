using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI HighScoreText;

    public float Score;
    public float HighScore;

    public float PtsPerSecond;

    public bool is_score;

    // Start is called before the first frame update
    void Start()
    {
        is_score = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_score)
            Score += PtsPerSecond * Time.deltaTime;
        if (HighScore < Score)
            HighScore = Score;
        scoreText.text = "Score : " + Mathf.Round(Score);
        HighScoreText.text = "High Score : " + Mathf.Round(HighScore);
    }
}
