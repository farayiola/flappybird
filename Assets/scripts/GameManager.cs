using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        pause();
    }

    public void play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }

    public void pause() { 
        Time.timeScale = 0f;
        player.enabled = false;
        
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        pause();
    }
    public void IncreaseScore() {
        score++;
        scoreText.text = score.ToString();
    }
}
