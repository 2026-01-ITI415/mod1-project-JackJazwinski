using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;

    void Start()
    {
        gameOverText.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
    }
}