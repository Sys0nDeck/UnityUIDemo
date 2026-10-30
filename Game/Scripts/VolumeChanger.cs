using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    private const string Volume = "Volume";

    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private Slider _slider;

    private float _volumeCoeff = 20f;
    private float _minVolume = -80f;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(SetSoundVolume);
        SetSoundVolume(_slider.value);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(SetSoundVolume);
    }

    public void SetSoundVolume(float value)
    {
        float currentVolume = 0f;
        if (value == 0)
            currentVolume = _minVolume;
        else
            currentVolume = GetVolume(value);

        _mixerGroup.audioMixer.SetFloat(_mixerGroup.name + Volume, currentVolume);
    }

    private float GetVolume(float value)
        => Mathf.Log10(value) * _volumeCoeff;
}
