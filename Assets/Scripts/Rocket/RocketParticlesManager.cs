using UnityEngine;

namespace Rocket
{
    public class RocketParticlesManager : MonoBehaviour
    {
        public ParticleSystem particles;
        private RocketUiMovement _uiMovement;
        private RocketState _rocketState;

        private void Update()
        {
            if (!_rocketState.Alive) return;
        
            if (_uiMovement.CanFlyUp)
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


        public void Init(RocketUiMovement uiMovement, RocketState rocketState)
        {
            _uiMovement = uiMovement;
            _rocketState = rocketState;
        }
    }
}