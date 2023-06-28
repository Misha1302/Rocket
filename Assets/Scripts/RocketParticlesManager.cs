using UnityEngine;

public class RocketParticlesManager : MonoBehaviour
{
    public ParticleSystem particles;
    private RocketUiMovement _uiMovement;
    private RocketHealth _health;

    private void Update()
    {
        if (_health.Died) return;
        
        if (_uiMovement != null && _uiMovement.CanFlyUp)
        {
            if (!particles.isPlaying)
                particles.Play();
        }
        else
        {
            if (particles.isPlaying)
                particles.Stop();
        }
    }


    public void Init(RocketUiMovement uiMovement, RocketHealth health)
    {
        _uiMovement = uiMovement;
        _health = health;
    }
}