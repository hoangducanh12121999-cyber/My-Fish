using UnityEditor.PackageManager;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    const int defaultScore = 0;
    const float defaultMusicVolume = 1f;
    const float defaultSFXVolume = 1f;

    public static int DataScore
    {
        get { return PlayerPrefs.GetInt(DataKey.ScoreKey, defaultScore); }
        set { PlayerPrefs.SetInt(DataKey.ScoreKey, value); }
    }
    public static float DataMusicVolume
    {
        get { return PlayerPrefs.GetFloat(DataKey.MusicVolumeKey, defaultMusicVolume); }
        set { PlayerPrefs.SetFloat(DataKey.MusicVolumeKey, value); }
    }

    public static float DataSFXVolume
    { 
        get { return PlayerPrefs.GetFloat(DataKey.SFXVolumeKey, defaultSFXVolume); }
        set { PlayerPrefs.SetFloat(DataKey.SFXVolumeKey, value); }
    }



}
