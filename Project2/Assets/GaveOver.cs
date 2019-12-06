using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GaveOver : MonoBehaviour
{
    public static int lives = 20;
    public GameObject gameOverUI;
    public GameObject mainUI;
    public Text livesText;
    //When the plaer runs out of lives the game is over
    void Update()
    {
        livesText.text = lives.ToString();
        if (lives <= 0)
        {
			Time.timeScale = 0f;
            mainUI.SetActive(false);
            gameOverUI.SetActive(true);
        }
    }
    void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
