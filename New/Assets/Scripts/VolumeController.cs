using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class VolumeController : MonoBehaviour
{

    [SerializeField] string volumeParameter = "Master Volume";
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider slide;
    [SerializeField] float multiplier = 30f;
    [SerializeField] AudioMixerGroup mixerGroup;


    private void Awake()
    {
        slide.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumeParameter, slide.value);
    }


    void Start()
    {
        slide.value = PlayerPrefs.GetFloat(volumeParameter, slide.value);
    }

    void Update()
    {
        if(slide.value == 0)
        {
            mixer.SetFloat(volumeParameter, 0);
        }
    }

    void HandleSliderValueChanged(float value)
    {
        mixer.SetFloat(volumeParameter, Mathf.Log10(value) * multiplier);
    }
}
