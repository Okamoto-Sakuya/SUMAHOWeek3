using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}