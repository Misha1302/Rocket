using UnityEngine;
using UnityEngine.Events;

namespace Rocket
{
    public class RocketCollisionManager : MonoBehaviour
    {
        public readonly UnityEvent<Collision> collisionEnter = new();

        private void OnCollisionEnter(Collision other)
        {
            collisionEnter.Invoke(other);
        }
    }
}