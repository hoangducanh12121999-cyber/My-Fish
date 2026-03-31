using UnityEngine;
using UnityEngine.SceneManagement;
[AddComponentMenu("Duc Anh/Audio Manager")]
public class AudioManager : Singleton<AudioManager>
{
    [Header("Audio Sources")]
    public AudioSource backGroundAudio;
    public AudioSource sfxAudio;

    [Header("Audio Clips")]
    public AudioClip hUDMusic;
    public AudioClip menuMusic;
    public AudioClip scoreClip;
    public AudioClip gameOverClip;
    public AudioClip onButtonClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnVolumeMusic(DataManager.DataMusicVolume);
        OnVolumeSfx(DataManager.DataSFXVolume);
    }


    public void PlayMusic(AudioClip clip)
    {
        backGroundAudio.clip = clip;
        backGroundAudio.loop = true;
        backGroundAudio.Play();
    }

    public void MenuMusic()
    {
        PlayMusic(menuMusic);
    }

    public void HUDMusic()
    {
        PlayMusic(hUDMusic);
    }

    public void PlaySfx(AudioClip clip)
    {
        sfxAudio.PlayOneShot(clip);
    }
    
    public void ScoreMusic()
    {
        PlaySfx(scoreClip);
    }

    public void GameOverMusic()
    {
        PlaySfx(gameOverClip);
        backGroundAudio.Stop();
    }

    public void OnButtonClickMusic()
    {
        PlaySfx(onButtonClip);
    }

    public void OnVolumeMusic(float volume)
    {
        backGroundAudio.volume = volume;
    }

    public void OnVolumeSfx(float volume)
    {
        sfxAudio.volume = volume;
    }
}
