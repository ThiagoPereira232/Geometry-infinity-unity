using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    public Text record;
    public Text scoreTextGameOver;

    private int highScore;

    public GameObject gameOver;
    public GameObject buttonRestart;
    public GameObject buttonPause;
    public GameObject scoreUi;


    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        highScore = PlayerPrefs.GetInt("highScore");

        Debug.Log(PlayerPrefs.GetInt("highScore"));
    }

    void Update()
    {
        UpdateHighScore();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        buttonRestart.SetActive(false);
        buttonPause.SetActive(false);
        scoreUi.SetActive(false);

        scoreTextGameOver.text = Score.ToString();
        record.text = highScore.ToString();
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void UpdateHighScore()
    {
        if(Score > highScore)
        {
            highScore = Score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }
}
