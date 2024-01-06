using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource ambient;
    [SerializeField] private Slider slidermusic;

    public AudioMixer audiomixer;
    public void Set0()
    {
        ambient.mute = true;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = slidermusic.value;
    }
}
