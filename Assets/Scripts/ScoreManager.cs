using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //public AudioClip scoreSound;
    public int pointValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered score trigger");
            GameManager.Instance.AddScore(pointValue);
            // AudioSource.PlayClipAtPoint(scoreSound, transform.position);
        }

    }
}
