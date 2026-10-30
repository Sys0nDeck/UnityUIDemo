using UnityEngine;
using UnityEngine.UI;

public class VolumeSwitcher : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private VolumeChanger _volumeChanger;

    private bool _isMute = false;

    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeMuteState);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeMuteState);
    }

    private void ChangeMuteState()
    {
        _isMute = !_isMute;

        if (_isMute)
        {
            _volumeChanger.SetSoundVolume(_volumeChanger.MinValue);
            _volumeChanger.enabled = false;
        }
        else
        {
            _volumeChanger.enabled = true;
        }
    }
}
