using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; // Hold ScoreManager reference
    public int scoreToGive;
    // Start is called before the first frame update
    void Start()
    {
        // find ScoreManager object
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase score
        // destroy this object
        Destroy(gameObject);
        // destroy other object
        Destroy(other.gameObject);
    }
}
