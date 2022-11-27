using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider volumeSlider;
    public float defaultVolume = 0.5f;

    public Slider effectsSlider;
    public float effectsDefaultVolume = 0.5f;

    public Slider difficulySlider;
    public float defaultDifficulty = 0f;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficulySlider.value = PlayerPrefsController.GetDifficulty();
        effectsSlider.value = PlayerPrefsController.GetEffectsVolume();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
	    {
		    musicPlayer.SetVolume(volumeSlider.value);
        }
    }

    public void SafeAndExit()
    {
        PlayerPrefsController.SetEffectsVolume(effectsSlider.value);
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty(difficulySlider.value);
        FindObjectOfType<LevelLoader>().LoadMenu();
    }

    public void SetDefault()
    {
        effectsSlider.value = effectsDefaultVolume;
        volumeSlider.value = defaultVolume;
        difficulySlider.value = defaultDifficulty;
    }
    
}
