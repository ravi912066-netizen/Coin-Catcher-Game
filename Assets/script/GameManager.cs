
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int lives = 3;

    public Text scoreText;
    public Text livesText;
    public Text gameOverText;

    private bool isGameOver = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Time.timeScale = 1f;

        UpdateUI();

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void AddScore(int amount)
    {
        if (isGameOver) return;

        score += amount;

        UpdateUI();
    }

    public void LoseLife()
    {
        if (isGameOver) return;

        lives--;

        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }

        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }

    void GameOver()
    {
        isGameOver = true;

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
            gameOverText.text = "GAME OVER";
        }

        Time.timeScale = 0f;
    }
}
