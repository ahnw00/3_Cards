using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SfxSlider : MonoBehaviour
{
    // Start is called before the first frame update
  public AudioMixer mixer;
  SoundManager soundManager;

    void Start()
    {
        soundManager = SoundManager.instance;
        GetComponent<Slider>().value = Mathf.Pow(10,soundManager.sfxVolume/20);
    } 

    public void SetSFXvolume(float sliderVal)
    {
        soundManager.sfxVolume = Mathf.Log10(sliderVal)*20;
        mixer.SetFloat("SFX", Mathf.Log10(sliderVal)*20);
    }
}
