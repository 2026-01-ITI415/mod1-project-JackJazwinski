using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject restartButton;
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }
    public void GameOver()
    {
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}