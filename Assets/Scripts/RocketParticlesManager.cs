using UnityEngine;

public class RocketParticlesManager : MonoBehaviour
{
    public ParticleSystem particles;
    private RocketUiMovement _uiMovement;

    private void Update()
    {
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


    public void Init(RocketUiMovement uiMovement)
    {
        _uiMovement = uiMovement;
    }
}