using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text scoreText;

    public TMP_Text lifeText;

    public GameObject gameOverPanel;

    private int score = 0;

    private int landedCount = 0;

    private int maxLand = 3;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateUI();

        gameOverPanel.SetActive(false);
    }

    public void AddScore(int value)
    {
        score += value;

        UpdateUI();
    }

    public void MeteorLanded()
    {
        landedCount++;

        UpdateUI();

        if (landedCount >= maxLand)
        {
            GameOver();
        }
    }

    void UpdateUI()
    {
        scoreText.text = "SCORE : " + score;

        lifeText.text =
            "Žc‚è : " + (maxLand - landedCount);
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);

        Time.timeScale = 0f;
    }
}