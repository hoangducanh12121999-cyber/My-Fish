using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioMain : MonoBehaviour
{
    public AudioSource musicMenuSource;
    public AudioClip musicMenuClip;

    void Awake()
    {
        Music();
    }

    void Update()
    {
        
    }

    void Music()
    {
        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "Option")
        {
            musicMenuSource.clip = musicMenuClip;
            musicMenuSource.loop = true;
            musicMenuSource.Play();
        }
    }
}
