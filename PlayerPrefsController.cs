using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string EFFECTS_VOLUME_KEY = "effects volume";
    const string DIFFCULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    const float MIN_EFFECTS = 0f;
    const float MAX_EFFECTS = 1f;

    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 2f;
    public static void SetMasterVolume(float volume)
    { 
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
	    {
            Debug.Log("Volume music: " + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
	    }   
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetEffectsVolume(float volume)
    {

        if (volume >= MIN_EFFECTS && volume <= MAX_EFFECTS)
        {
            Debug.Log("Volume effects: " + volume);
            PlayerPrefs.SetFloat(EFFECTS_VOLUME_KEY, volume);
            AudioListener.volume = volume;
            Debug.Log("testttt : " + AudioListener.volume);
        }
        else
        {
            Debug.LogError("Effects volume is out of range");
        }
    }
    public static float GetEffectsVolume()
    {
        return PlayerPrefs.GetFloat(EFFECTS_VOLUME_KEY);
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY)
	    {
		    PlayerPrefs.SetFloat(DIFFCULTY_KEY, difficulty);
	    }
        else
        {
            Debug.LogError("difficulty not in range");
        }
    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFCULTY_KEY);
    }
}
