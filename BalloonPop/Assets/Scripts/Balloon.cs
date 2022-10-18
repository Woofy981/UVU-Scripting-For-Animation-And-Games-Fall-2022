using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
     public int clicksToPop = 3, givePoints = 125;
    public float increaseScale = 0.20f;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        // find the scoreManager object
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    
     void OnMouseDown()
    {
        // Decrease amount to click before popping
        clicksToPop -= 1;
        // Increase balloon size
        transform.localScale += Vector3.one * increaseScale;

        if(clicksToPop == 0)
        {
            // Add points to score text
            scoreManager.IncreaseScoreText(givePoints);
            // Destroy balloon
            Destroy(gameObject);
        }
    }
}
