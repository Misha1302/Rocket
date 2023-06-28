using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private RocketUiMovement rocketUiMovement;
    [SerializeField] private RocketMovement rocketMovement;
    [SerializeField] private RocketParticlesManager particlesManager;

    private void Start()
    {
        ScreenManager.Init();
        particlesManager.Init(rocketUiMovement);
        rocketMovement.Init(rocketUiMovement);
    }
}