using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource music; // AudioSource for music
    [SerializeField] private AudioSource ambient; // AudioSource for ambient sounds
    [SerializeField] private Slider slidermusic; // Slider UI element to control music volume

    public AudioMixer audiomixer; // Reference to the AudioMixer

    // Method to mute ambient sounds
    public void SetAmbientOn()
    {
        ambient.mute = true;
    }

    // Method to unmute ambient sounds
    public void SetAmbientOff()
    {
        ambient.mute = false;
    }

    // Method to mute music
    public void SetMusicOn()
    {
        music.mute = true;
    }

    // Method to unmute music
    public void SetMusicOff()
    {
        music.mute = false;
    }

    // Method to change volume using a Slider UI element
    public void ChangeVolume()
    {
        AudioListener.volume = slidermusic.value;
    }
}
