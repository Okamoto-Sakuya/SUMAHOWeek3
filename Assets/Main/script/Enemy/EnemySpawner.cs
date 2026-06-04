using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;

    public float spawnInterval = 2f;

    private BoxCollider2D spawnArea;

    void Start()
    {
        spawnArea = GetComponent<BoxCollider2D>();

        InvokeRepeating(nameof(SpawnMeteor), 1f, spawnInterval);
    }

    void SpawnMeteor()
    {
        Bounds bounds = spawnArea.bounds;

        float randomX =
            Random.Range(bounds.min.x, bounds.max.x);

        float randomY =
            Random.Range(bounds.min.y, bounds.max.y);

        Vector3 spawnPos =
            new Vector3(randomX, randomY, 0f);

        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
    }
}