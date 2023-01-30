using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SfxSlider : MonoBehaviour
{
    // Start is called before the first frame update
  public AudioMixer mixer;

    public void SetSFXvolume(float sliderVal)
    {
        mixer.SetFloat("SFX", Mathf.Log10(sliderVal)*20);
    }
}
