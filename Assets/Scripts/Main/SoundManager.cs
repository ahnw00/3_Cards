using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioMixer audioMixer;
    public float bgmVolume;
    public float sfxVolume;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioMixer.SetFloat("BGM", -10);
        audioMixer.SetFloat("SFX", 0); // 이런식으로 사용하면 돼 ^^
    }
}
