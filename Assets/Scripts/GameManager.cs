using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private int score;

    void Start()
    {
        score = 0;
    }

    public void AddScore(int point)
    {
        score += point;
    }

    public int GetScore()
    {
        return score;
    }




}
