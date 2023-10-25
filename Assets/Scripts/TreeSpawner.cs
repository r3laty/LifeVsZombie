using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject treePrefab;
    [SerializeField] private float spawnInterval = 5;
    [SerializeField] private float spawnRadius = 10;

    private float _lastSpawnTime;
    private void Start()
    {
        _lastSpawnTime = Time.time;
    }
    private void Update()
    {
        if (Time.time - _lastSpawnTime >= spawnInterval)
        {
            SpawnTree();
            _lastSpawnTime = Time.time;
        }
    }

    private bool IsTreeNearby()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, spawnRadius);
        return colliders.Length > 0;
    }

    private void SpawnTree()
    {
        // ���������� ����������� � ������������ �������� ���������� Y ��� ������.
        float minY = 0; // ����������� ������.
        float maxY = 0.1f; // ������������ ������.

        // ������� ����� ������ �� ������� �� ��������� ������� XZ � ������������ ������� Y.
        Vector3 spawnPosition = new Vector3(
            transform.position.x + Random.Range(-spawnRadius, spawnRadius),
            Random.Range(minY, maxY),
            transform.position.z + Random.Range(-spawnRadius, spawnRadius)
        );
        GameObject newTree = Instantiate(treePrefab, spawnPosition, Quaternion.identity);
    }
}
