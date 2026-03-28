using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public AudioSource backGroundMenuAudio;
    public AudioClip backGroundMenuMusic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backGroundMenuAudio = GetComponent<AudioSource>();
        PlayMenuMusic(backGroundMenuMusic);
    }

    private void PlayMenuMusic(AudioClip clip)
    {
        backGroundMenuAudio.clip = clip;
        backGroundMenuAudio.loop = true;
        backGroundMenuAudio.Play();

    }
}
