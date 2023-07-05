using UnityEngine;

namespace Rocket
{
    public class RocketDeath : MonoBehaviour
    {
        [SerializeField] private ParticleSystem particles;
        [SerializeField] private GameObject[] rocketObjects;
        private bool _done;

        public void Die()
        {
            if (_done) return;
            _done = true;

            particles.Play();
            DestroyRocket();
            Invoke(nameof(ReloadScene), 2.75f);
        }

        private void DestroyRocket()
        {
            foreach (var obj in rocketObjects) 
                obj.AddComponent<Rigidbody>().AddForce(new Vector3(Random.value - 0.5f, Random.value - 0.5f, 0) * 2000);
        }

        private void ReloadScene()
        {
            RocketSceneManager.Reload();
        }
    }
}