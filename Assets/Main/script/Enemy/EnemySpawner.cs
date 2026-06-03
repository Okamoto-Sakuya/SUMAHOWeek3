using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;

    public float spawnInterval = 2f;

    public float spawnX = 500f;
    public float spawnY = 1000f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnMeteor), 1f, spawnInterval);
    }

    void SpawnMeteor()
    {
        float randomX = Random.Range(-spawnX, spawnX);

        Vector3 pos = new Vector3(randomX, spawnY, 0);

        Instantiate(meteorPrefab, pos, Quaternion.identity, transform);
    }
}