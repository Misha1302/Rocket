using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RocketMovement : MonoBehaviour
{
    [SerializeField] private float flySpeed = 40;
    [SerializeField] private float rotateSpeed = 1000;

    private Rigidbody _rb;
    private RocketHealth _rocketHealth;
    private RocketUiMovement _rocketUiMovement;

    private void FixedUpdate()
    {
        if (_rocketHealth.Died) return;

        if (_rocketUiMovement.CanFlyUp)
            FlyUp();
        if (_rocketUiMovement.CanRotateLeft)
            FlySide(-1);
        if (_rocketUiMovement.CanRotateRight)
            FlySide(1);
    }

    private void FlySide(int multiplier)
    {
        _rb.transform.Rotate(Vector3.right * (rotateSpeed * multiplier * Time.fixedDeltaTime));
    }

    private void FlyUp()
    {
        _rb.AddForce(_rb.transform.up * flySpeed);
    }

    public void Init(RocketUiMovement rocketUiMovement, RocketHealth rocketHealth)
    {
        _rocketUiMovement = rocketUiMovement;
        _rocketHealth = rocketHealth;
        _rb = GetComponent<Rigidbody>();
    }
}