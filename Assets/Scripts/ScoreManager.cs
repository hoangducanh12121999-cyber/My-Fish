using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public AudioClip scoreClip;
    public int pointValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySfxScore(scoreClip);
            GameEvent.eventScore?.Invoke(pointValue);
        }

    }
}
