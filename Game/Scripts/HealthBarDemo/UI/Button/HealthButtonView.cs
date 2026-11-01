using UnityEngine;
using UnityEngine.UI;

public abstract class HealthButtonView : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    protected abstract void OnButtonClicked();
}
