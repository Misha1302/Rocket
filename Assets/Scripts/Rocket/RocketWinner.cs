using System.Collections;
using UnityEngine;

namespace Rocket
{
    using Other;

    public class RocketWinner : MonoBehaviour
    {
        [SerializeField] private ParticleSystem particles;
        private RocketState _rocketState;
        public bool Won { get; private set; }

        public void Init(RocketCollisionManager collisionManager, RocketState rocketState)
        {
            _rocketState = rocketState;
            collisionManager.collisionEnter.AddListener(OnColEnter);
        }

        private void OnColEnter(Collision col)
        {
            if (!_rocketState.Alive) return;
            if (!col.transform.TryGetComponent<WinCollider>(out _)) return;

            Won = true;
            particles.Play();
            StartCoroutine(LoadNextAfterSeconds(2));
        }

        private static IEnumerator LoadNextAfterSeconds(float s)
        {
            yield return new WaitForSeconds(s);
            RocketSceneManager.LoadNext();
        }
    }
}