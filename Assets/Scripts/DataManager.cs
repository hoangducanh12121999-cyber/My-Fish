using UnityEditor.PackageManager;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    const int defaultScore = 0;
    const float defaultVolume = 1f;

    public static int DataScore
    {
        get { return PlayerPrefs.GetInt(DataKey.ScoreKey, defaultScore); }
        set { PlayerPrefs.SetInt(DataKey.ScoreKey, value); }
    }
    public static float DataMusicVolume
    {
        get { return PlayerPrefs.GetFloat(DataKey.MusicVolumeKey, defaultVolume); }
        set { PlayerPrefs.SetFloat(DataKey.MusicVolumeKey, value); }
    }

    public static float DataSFXVolume
    { 
        get { return PlayerPrefs.GetFloat(DataKey.SFXVolumeKey, defaultVolume); }
        set { PlayerPrefs.SetFloat(DataKey.SFXVolumeKey, value); }
    }



}
