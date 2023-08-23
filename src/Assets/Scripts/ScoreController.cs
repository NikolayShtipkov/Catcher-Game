using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameOverScreen gameOverScreen;

    private int score;

    float currentTime = 0f;
    float startingTime = 60f;

    [SerializeField] TextMeshProUGUI countdownText;

    void Start()
    {
        currentTime = startingTime;
        Time.timeScale = 1f;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("00");

        if (currentTime <= 0)
        {
            gameOverScreen.Setup(score);
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            gameOverScreen.Setup(score);
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Coin")
        {
            Destroy(target.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }
}
