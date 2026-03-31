using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int pointValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.ScoreMusic();
            GameEvent.eventScore?.Invoke(pointValue);
        }

    }
}
