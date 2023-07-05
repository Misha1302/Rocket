using UnityEngine;

namespace Other
{
    public class LiftingForce : MonoBehaviour
    {
        [SerializeField] private float force;

        private void OnTriggerStay(Collider other)
        {
            if (other.transform.parent.TryGetComponent(out Rigidbody rb) || other.TryGetComponent(out rb))
                rb.AddForce(transform.up * force);
        }
    }
}