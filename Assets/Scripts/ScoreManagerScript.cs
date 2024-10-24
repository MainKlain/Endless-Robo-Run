using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            //increase score of 1
            score++;
            Debug.Log(score);
        }
    }
}
