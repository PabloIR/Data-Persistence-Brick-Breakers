using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField playerInput;
    [SerializeField] Slider difficultySlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        //If the Player name input field exist save player name
        if(playerInput != null)
        {
            GameManager.gameManager.playerName = playerInput.text;
        }
        //Load Scene of index 1
        SceneManager.LoadScene(1);
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        //If the difficulty slider exist save the difficulty
        if(difficultySlider != null)
        {
            GameManager.gameManager.difficultySetting = (int) difficultySlider.value;
        }
        SceneManager.LoadScene(0);
    }
}
