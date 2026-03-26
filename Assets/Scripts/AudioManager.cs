using UnityEngine;
[AddComponentMenu("Duc Anh/Audio Manager")]
public class AudioManager : Singleton<AudioManager>
{
    [Header("Audio Sources")]
    public AudioSource backGroundAudio;
    public AudioSource sfxScoreAudio;
    public AudioSource gameOverAudio;
    [Header("Audio Clips")]
    public AudioClip backGroundMusic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayMusic(backGroundMusic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayMusic(AudioClip clip)
    {
        backGroundAudio.clip = clip;
        backGroundAudio.loop = true;
        backGroundAudio.Play();
    }
    public void PlaySfxScore(AudioClip clip)
    {
        sfxScoreAudio.PlayOneShot(clip);
    }
    public void GameOver(AudioClip clip)
    {
        gameOverAudio.PlayOneShot(clip);
        backGroundAudio.Stop();
    }
}
