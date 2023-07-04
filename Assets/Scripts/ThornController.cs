using System;
using UnityEngine;

public class ThornController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private string triggerName = "Attack";
    private int _attackHash;

    private void Start()
    {
        _attackHash = Animator.StringToHash(triggerName);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<RocketHealth>())
            anim.SetTrigger(_attackHash);
    }
}