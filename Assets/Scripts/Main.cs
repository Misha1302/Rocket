using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private RocketUiMovement rocketUiMovement;
    [SerializeField] private RocketMovement rocketMovement;

    private void Start()
    {
        ScreenManager.Init();
        rocketMovement.Init(rocketUiMovement);
    }
}