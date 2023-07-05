using UnityEngine;

namespace Other
{
    public class TreeSpawner : MonoBehaviour
    {
        [SerializeField] private Transform[] points;
        [SerializeField] private Transform tree;
        [SerializeField] private int count;

        private void Start()
        {
            for (var i = 0; i < count; i++)
            {
                var treeInstance = Instantiate(tree);
                treeInstance.position = points[Random.Range(0, points.Length)].position;
            }
        }
    }
}