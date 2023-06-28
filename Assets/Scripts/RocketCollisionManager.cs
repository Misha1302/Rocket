using UnityEngine;
using UnityEngine.Events;

public class RocketCollisionManager : MonoBehaviour
{
    public readonly UnityEvent<Collision> collisionEnter = new();
    public readonly UnityEvent<Collision> collisionStay = new();

    private void OnCollisionEnter(Collision other)
    {
        collisionEnter.Invoke(other);
    }

    private void OnCollisionStay(Collision other)
    {
        collisionStay.Invoke(other);
    }
}