using UnityEngine;
using UnityEngine.UI;

public class OptionUI : MonoBehaviour
{
    public Slider sliderMusic;
    public Slider sliderSfx;

    private void Start()
    {
        sliderMusic.value = DataManager.DataMusicVolume;
        sliderSfx.value = DataManager.DataSFXVolume;
    }

    public void UpdateAudio(float volume)
    {
        AudioManager.Instance.OnVolumeMusic(volume);
        DataManager.DataMusicVolume = volume;
    }

    public void UpdateSfx(float volume)
    {
        AudioManager.Instance.OnVolumeSfx(volume);
        DataManager.DataSFXVolume = volume;
    }
}
