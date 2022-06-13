using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoreUIHandler : MonoBehaviour
{
    [SerializeField] Text highScoreNameText;
    [SerializeField] Text highScoreText;
    void Start()
    {
        if (GameManager.gameManager != null)
        {
            highScoreNameText.text = "Name: " + GameManager.gameManager.highScoreName;
            highScoreText.text = "Score: " + GameManager.gameManager.highScore;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
