using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void IncreaseScore(int amount)
    {
        score += amount; // add points to score
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; // subtract points from score
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
