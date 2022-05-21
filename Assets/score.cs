using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    private float score_nb = 0.0f;
    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;

    //private bool isDead = false;

    //public Text scoreText;
    //public DeathMenu deathMenu;

    void Update()
    {
        if (score_nb >= scoreToNextLevel)
            LevelUp();
        
        score_nb += Time.deltaTime * difficultyLevel;
        //scoreText.text = ((int) score_nb).ToString();
    }

    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;

        scoreToNextLevel *= 2;
        difficultyLevel++;

        //GetComponent<PlayerMotor>().SetSpeed (difficultyLevel);

        Debug.Log (difficultyLevel);
    }
    void OnDeath()
    {
        //isDead = true;
        PlayerPrefs.SetFloat("Highscore", score_nb);
        //PlayerPrefs.GetFloat
        //deathMenu.ToggleEndMenu(score_nb);
    }
}
