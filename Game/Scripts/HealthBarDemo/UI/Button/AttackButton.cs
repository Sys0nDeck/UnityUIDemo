using UnityEngine;

public class AttackButton : HealthButtonView
{
    [SerializeField] private int _damage;

    protected override void OnButtonClicked()
    {
        Health.TakeDamage(_damage);
    }
}
