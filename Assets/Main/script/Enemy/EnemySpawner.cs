using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public RectTransform canvasTransform;

    [Header("Lane Targets (UI Image)")]
    public RectTransform leftLane;
    public RectTransform centerLane;
    public RectTransform rightLane;

    [Header("Spawn")]
    public float spawnY = 500f;
    public float spawnInterval = 2f;

    [Header("Enemy Speed")]
    public float enemySpeed = 200f;
    public float speedUpRate = 5f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        enemySpeed += speedUpRate * Time.deltaTime;

        if (timer >= spawnInterval)
        {
            Spawn();
            timer = 0f;
        }
    }

    void Spawn()
    {
        GameObject enemy = Instantiate(enemyPrefab, canvasTransform);
        RectTransform rect = enemy.GetComponent<RectTransform>();

        int lane = Random.Range(0, 3);

        RectTransform targetLane = leftLane;

        if (lane == 1) targetLane = centerLane;
        if (lane == 2) targetLane = rightLane;

        rect.anchoredPosition = new Vector2(
            targetLane.anchoredPosition.x,
            spawnY
        );

        EnemyUI enemyScript = enemy.GetComponent<EnemyUI>();
        enemyScript.fallSpeed = enemySpeed;
    }
}