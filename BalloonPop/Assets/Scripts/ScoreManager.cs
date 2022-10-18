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
        UpdateScoreText();
    }

    public void IncreaseScoreText(int n)
    {
        score += n;
        UpdateScoreText();
    }

    public void DecreaseScoreText(int n)
    {
        score -= n;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
