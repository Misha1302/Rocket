using UnityEngine;

public class PermanentDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    public float GetDamage() => damage;
}