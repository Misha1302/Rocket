using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private RocketUiMovement rocketUiMovement;
    [SerializeField] private RocketMovement rocketMovement;
    [SerializeField] private RocketParticlesManager particlesManager;
    [SerializeField] private RocketCollisionManager collisionManager;
    [SerializeField] private RocketWinner rocketWinner;
    [SerializeField] private RocketState rocketState;
    [SerializeField] private RocketHealth health;
    [SerializeField] private RocketDeath death;

    private void Start()
    {
        ScreenManager.Init();
        particlesManager.Init(rocketUiMovement, rocketState);
        rocketMovement.Init(rocketUiMovement, rocketState);
        health.Init(collisionManager, death, rocketState);
        rocketWinner.Init(collisionManager, rocketState);
        rocketState.Init(health, rocketWinner);
    }
}