using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject GetReady;

    public static int gameScore;
    public GameObject score;

    public static bool gameStarted;
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        gameOver = false;
    }
    void Start()
    {
        
        gameStarted = false;
    }

    public void GameStarted()
    {
        gameStarted = true;
        GetReady.SetActive(false);
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);

        score.SetActive(false);
        gameScore = score.GetComponent<Score>().GetScore();
    }

    public void restartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        
    }
}
