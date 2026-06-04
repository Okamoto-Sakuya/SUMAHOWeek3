using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader1 : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void LoadScene()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(sceneName);
    }
}