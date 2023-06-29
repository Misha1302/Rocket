using UnityEngine;

public class RocketHealth : MonoBehaviour
{
    private RocketDeath _death;
    private float _health = 100f;
    public bool Died => _health <= 0;

    public void Init(RocketCollisionManager rocketCollisionManager, RocketDeath death)
    {
        rocketCollisionManager.collisionEnter.AddListener(OnCollision);
        _death = death;
    }

    private void OnCollision(Collision col)
    {
        if (col.gameObject.TryGetComponent<LethalDamage>(out _))
        {
            _health = -1;
            _death.Die();
        }
        else if (col.gameObject.TryGetComponent<PermanentDamage>(out var damage))
        {
            _health -= damage.GetDamage();
            if (_health <= 0)
                _death.Die();
        }
    }
}