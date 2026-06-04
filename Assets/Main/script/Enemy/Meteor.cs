using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0f;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = Vector2.down * fallSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 地面
        if (collision.CompareTag("Ground"))
        {
            GameManager.instance.MeteorLanded();

            Destroy(gameObject);
        }

        // ミサイル
        if (collision.CompareTag("Missile"))
        {
            GameManager.instance.AddScore(100);

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}