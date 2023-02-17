using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class BgmSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer mixer;
    SoundManager soundManager;

    void Start()
    {
        soundManager = SoundManager.instance;
        GetComponent<Slider>().value = Mathf.Pow(10,soundManager.bgmVolume/20);
    }

    public void SetBGMvolume(float sliderVal)
    {
        soundManager.bgmVolume = Mathf.Log10(sliderVal)*20;
        mixer.SetFloat("BGM", soundManager.bgmVolume);
    }


}
