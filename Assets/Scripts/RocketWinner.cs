using System.Collections;
using UnityEngine;

public class RocketWinner : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;
    public bool Won { get; private set; }

    public void Init(RocketCollisionManager collisionManager)
    {
        collisionManager.collisionEnter.AddListener(OnColEnter);
    }

    private void OnColEnter(Collision col)
    {
        if (!col.transform.TryGetComponent<WinCollider>(out _)) return;

        Won = true;
        particles.Play();
        StartCoroutine(LoadNextAfterSeconds(2));
    }

    private static IEnumerator LoadNextAfterSeconds(float s)
    {
        yield return new WaitForSeconds(s);
        RocketSceneManager.LoadNext();
    }
}