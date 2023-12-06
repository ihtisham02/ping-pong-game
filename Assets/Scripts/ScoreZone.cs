using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreZone : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject gameObjectScreen;

    private int score;
    void Start()
    {
        score = 0;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<BallController>() != null)
        {
            score++;
            scoreText.text = score.ToString();
            col.gameObject.GetComponent<BallController>().ResetBall();
        }
        if (score>=7)
        {
            col.gameObject.SetActive(false);
            gameObjectScreen.SetActive(true);
        }
    }
}
