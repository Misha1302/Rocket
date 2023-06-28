using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private RocketUiMovement rocketUiMovement;
    [SerializeField] private RocketMovement rocketMovement;
    [SerializeField] private RocketParticlesManager particlesManager;
    [SerializeField] private RocketCollisionManager collisionManager;
    [SerializeField] private RocketHealth health;
    [SerializeField] private RocketDeath death;

    private void Start()
    {
        ScreenManager.Init();
        particlesManager.Init(rocketUiMovement, health);
        rocketMovement.Init(rocketUiMovement, health);
        health.Init(collisionManager, death);
    }
}