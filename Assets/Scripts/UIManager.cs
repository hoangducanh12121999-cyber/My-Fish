using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("StartDelay", 0.1f);
    }

    void StartDelay()
    {
        GameEvent.eventScoreComplete.AddListener(UpdateScoreText);
    }

    void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();  
    }
}
