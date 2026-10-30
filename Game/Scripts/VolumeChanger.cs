using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private Slider _slider;

    private const string Volume = "Volume";

    private float _minSliderValue = 0.0001f;

    public float MinValue => _minSliderValue;

    private void Awake()
    {
        _slider.minValue = _minSliderValue;
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(SetSoundVolume);
        SetSoundVolume(_slider.value);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(SetSoundVolume);
    }

    private void Start()
    {
        SetSoundVolume(_slider.value);
    }

    public void SetSoundVolume(float value)
    {
        float currentVolume = GetVolume(value);
        _mixerGroup.audioMixer.SetFloat(_mixerGroup.name + Volume, currentVolume);
    }

    private float GetVolume(float value)
        => Mathf.Log10(value) * 20;
}
