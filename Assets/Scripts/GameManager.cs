using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private int score;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "HUD")
        {
            AudioManager.Instance.HUDMusic();
        }

        if (GameEvent.eventUpdateUI == null)
        {
            GameEvent.eventUpdateUI = new UnityEngine.Events.UnityEvent();
        }
        if (GameEvent.eventScore == null)
        {
            GameEvent.eventScore = new UnityEngine.Events.UnityEvent<int>();
        }
        if (GameEvent.eventScoreComplete == null)
        {
            GameEvent.eventScoreComplete = new UnityEngine.Events.UnityEvent<int>();
        }

        GameEvent.eventScore.AddListener(AddPoint);
    }

    public void AddPoint(int point)
    {
        score += point;
        GameEvent.eventScoreComplete?.Invoke(score);
    }

    public int GetScore()
    {
        return score;
    }




}
