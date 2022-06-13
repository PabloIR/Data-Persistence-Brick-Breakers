using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameUIHandler : MonoBehaviour
{
    [SerializeField] Text highScoreText;
    void Start()
    {
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        highScoreText.text = "Best Score : " + GameManager.gameManager.highScoreName + " : " + GameManager.gameManager.highScore;
    }
}
