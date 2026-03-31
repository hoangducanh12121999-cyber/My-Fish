using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    private int highScore;

    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }


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
        Highscore();
        GameEvent.eventScoreComplete?.Invoke(score);
    }

    public void Highscore()
    {
        if (score >= highScore)
        {
            highScore = score;
        }
        DataManager.DataHighScore = highScore;
        GameEvent.eventHighScore?.Invoke(highScore);
    }


    

}
