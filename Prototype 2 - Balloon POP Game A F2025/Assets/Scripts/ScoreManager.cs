using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add the UI Namespace

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; // Reference the UI Text

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; //Increase score by amount
        UpdateScoreText(); //Update score Text UI
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount; //Decrease score by amount
        UpdateScoreText(); //Update score Text UI
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
