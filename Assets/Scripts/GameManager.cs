using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private int score;
    private int highScore;

    

    void Start()
    {
        

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
        if (GameEvent.eventHighScore == null)
        {
            GameEvent.eventHighScore = new UnityEngine.Events.UnityEvent<int>();
        }


        GameEvent.eventScore.AddListener(AddPoint);

        this.highScore = DataManager.DataHighScore;
    }

    public void AddPoint(int point)
    {
        score += point;
        GameEvent.eventScoreComplete?.Invoke(score);
    }

    public void HighScore()
    {
        if (score >= highScore)
        {
            highScore = score;
        }
        DataManager.DataHighScore = highScore;
        GameEvent.eventHighScore?.Invoke(highScore);
    }

    public int GetHighScore()
    {
        return highScore;
    }

}
