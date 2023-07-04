using System;
using UnityEngine;

public class LevitatingPlatformController : MonoBehaviour
{
    [SerializeField] private new Camera camera;
    [SerializeField] private float speed;
    [SerializeField] private float time;

    private void Start()
    {
        // don't use '??=' operator
        if(camera == null)
            camera = Camera.main;
    }

    private void Update()
    {
        transform.rotation = camera.transform.rotation;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * (speed * MathF.Sin(Time.time * time)));
    }
}