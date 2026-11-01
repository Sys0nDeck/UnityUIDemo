using UnityEngine;

public class HealButton : HealthButtonView
{
    [SerializeField] private int _healPoint;

    protected override void OnButtonClicked()
    {
        Health.Heal(_healPoint);
    }
}
