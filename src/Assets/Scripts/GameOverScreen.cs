using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Setup(int score)
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        scoreText.text = "Score: " + score.ToString();
    }

    public void TryAgainButton()
    {
        SceneManager.LoadScene(1);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
