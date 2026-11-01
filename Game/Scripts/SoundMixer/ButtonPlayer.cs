using UnityEngine;
using UnityEngine.UI;

public class ButtonPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private Button _button;

    private void OnEnable ()
    {
        _button.onClick.AddListener(Play);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Play);
    }

    private void Play()
    {
        _source.Play();
    }
}
