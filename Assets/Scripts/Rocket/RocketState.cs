using UnityEngine;

namespace Rocket
{
    public class RocketState : MonoBehaviour
    {
        private RocketHealth _health;
        private RocketWinner _winner;
        public bool Alive => !_health.Died && !_winner.Won;

        public void Init(RocketHealth health, RocketWinner winner)
        {
            _health = health;
            _winner = winner;
        }
    }
}