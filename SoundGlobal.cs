using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGlobal : MonoBehaviour
{
    AudioListener audioListener;

    // Start is called before the first frame update
    void Start()
    {
        var msplayer = FindObjectOfType<MusicPlayer>().GetComponent<AudioSource>();
        msplayer.ignoreListenerVolume = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TestSounds()
    {
        AudioListener.volume = 0f;
    }
}
