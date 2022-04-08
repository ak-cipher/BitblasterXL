using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public Text highScoreText;
    public int highScore;

    private void Awake()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            this.highScore = PlayerPrefs.GetInt("HighScore");
            
        }
        else
        {
            this.highScore = 0;
            PlayerPrefs.SetInt("Highcore",0);
        }

        this.highScoreText.text = "HighScore : " + this.highScore.ToString();
    }

    public void OnPlayClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void OnMenuClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void OnExitClick()
    {
        Application.Quit();
    }

}
