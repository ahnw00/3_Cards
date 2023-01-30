using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class BgmSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer mixer;

    public void SetBGMvolume(float sliderVal)
    {
        mixer.SetFloat("BGM", Mathf.Log10(sliderVal)*20);
    }
}
